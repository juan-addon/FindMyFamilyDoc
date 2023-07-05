using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Business.Services
{
    public class DoctorAvailabilityService : IDoctorAvailabilityService
    {
        private readonly DatabaseContext _dbContext;

        public DoctorAvailabilityService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetAvailabilityByDoctorIdAsync(string doctorId)
        {
            try
            {
                var availabilities = await _dbContext.DoctorAvailabilities
                    .Include(m => m.Doctor)
                    .Where(a => a.Doctor.UserId == doctorId)
                    .ToListAsync();

                var availabilityViewModels = availabilities
                    .OrderBy(m => m.DayOfWeek)
                    .Select(a => new DoctorAvailabilityViewModel
                {
                    AvailabilityId = a.Id,
                    DayOfWeek = a.DayOfWeek.ToString(),
                    FromTime = a.FromTime,
                    ToTime = a.ToTime,
                    AppointmentLength = a.AppointmentLength,
                    DoctorId = a.Doctor.UserId,
                    IsActive = a.IsActive
                }).ToList();

                return new Result<IEnumerable<DoctorAvailabilityViewModel>>(availabilityViewModels);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<DoctorAvailabilityViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while retrieving the doctor availabilities: {ex.Message}");
            }
        }

        public async Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetDoctorAvailabilityByStaffIdAsync(string staffId)
        {
            try
            {
                var staff = await _dbContext.DoctorStaffs.FirstOrDefaultAsync(s => s.UserId == staffId);

                if (staff == null || staff.DoctorId == 0)
                {
                    return new Result<IEnumerable<DoctorAvailabilityViewModel>>(ApiErrorCode.NotFound.ToString(), $"Staff with id {staffId} not found or it doesn't have an associated Doctor.");
                }

                // Use the DoctorId associated with the staff to retrieve the availabilities
                var availabilities = await _dbContext.DoctorAvailabilities
                    .Include(m => m.Doctor)
                    .Where(a => a.Doctor.Id == staff.DoctorId)
                    .ToListAsync();

                var availabilityViewModels = availabilities
                    .OrderBy(m => m.DayOfWeek)
                    .Select(a => new DoctorAvailabilityViewModel
                    {
                        AvailabilityId = a.Id,
                        DayOfWeek = a.DayOfWeek.ToString(),
                        FromTime = a.FromTime,
                        ToTime = a.ToTime,
                        AppointmentLength = a.AppointmentLength,
                        DoctorId = a.Doctor.UserId,
                        IsActive = a.IsActive
                    }).ToList();

                return new Result<IEnumerable<DoctorAvailabilityViewModel>>(availabilityViewModels);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<DoctorAvailabilityViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while retrieving the doctor availabilities: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> AddAvailabilityAsync(IEnumerable<DoctorAvailabilityViewModel> newAvailabilities)
        {
            // Start the transaction.
            var days = new List<string>();
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                foreach (var newAvailability in newAvailabilities)
                {
                    // Validate DayOfWeek enum
                    _ = Enum.TryParse<WeekDay>(newAvailability.DayOfWeek, true, out var weekDayValue)
                    ? weekDayValue
                    : throw new ValidationException($"Invalid WeekDay value: {newAvailability.DayOfWeek}");

                    // Validate if doctor exists
                    var (currentDoctor, error) = await GetDoctorIdByDoctorUserOrStaff(newAvailability.DoctorId, newAvailability.StaffId);
                    if (currentDoctor == null)
                    {
                        return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), error ?? "Doctor not found.");
                    }

                    // Validate if doctor already has an availability for the same day
                    var availabilityExists = await _dbContext.DoctorAvailabilities
                        .Include(m => m.Doctor)
                        .AnyAsync(a => a.Doctor.UserId == newAvailability.DoctorId && a.DayOfWeek == weekDayValue);
                    if (availabilityExists)
                        return new Result<dynamic>(ApiErrorCode.Conflict.ToString(), $"An availability for {weekDayValue} already exists for this doctor.");

                    // Mapping and adding new availability
                    var availability = new DoctorAvailability
                    {
                        DayOfWeek = weekDayValue,
                        FromTime = newAvailability.FromTime,
                        ToTime = newAvailability.ToTime,
                        AppointmentLength = newAvailability.AppointmentLength,
                        DoctorId = currentDoctor.Id,
                        IsActive = newAvailability.IsActive
                    };

                    await _dbContext.DoctorAvailabilities.AddAsync(availability);
                    await _dbContext.SaveChangesAsync();

                    newAvailability.AvailabilityId = availability.Id;
                    days.Add(weekDayValue.ToString());
                }

                // Commit transaction if all commands succeed.
                await transaction.CommitAsync();
                return new Result<dynamic>(new
                {
                    Days = days,
                    Message = $"Your availabilities have been successfully added for the following days: {string.Join(", ", days)}."
                });
            }
            catch (Exception ex)
            {
                // Rollback transaction if exception occurred.
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while adding the availability: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> UpdateAvailabilityAsync(IEnumerable<DoctorAvailabilityViewModel> updatedAvailabilities)
        {
            var days = new List<string>();
            // Start the transaction.
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                foreach (var updatedAvailability in updatedAvailabilities)
                {
                    // Validate if availability exists
                    var availability = await _dbContext.DoctorAvailabilities.FindAsync(updatedAvailability.AvailabilityId);
                    if (availability == null)
                        return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), $"Availability {updatedAvailability.AvailabilityId} not found.");
                    
                    // Validate DayOfWeek enum
                    _ = Enum.TryParse<WeekDay>(updatedAvailability.DayOfWeek, true, out var weekDayValue)
                    ? weekDayValue
                    : throw new ValidationException($"Invalid WeekDay value: {availability.DayOfWeek}");

                    // Validate if doctor exists
                    var (currentDoctor, error) = await GetDoctorIdByDoctorUserOrStaff(updatedAvailability.DoctorId, updatedAvailability.StaffId);
                    if (currentDoctor == null)
                    {
                        return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), error ?? "Doctor not found.");
                    }

                    // Validate if doctor already has an availability for the same day (ignoring current)
                    var otherAvailabilityExists = await _dbContext.DoctorAvailabilities
                        .AnyAsync(a => a.DoctorId == currentDoctor.Id &&
                                       a.DayOfWeek == weekDayValue &&
                                       a.Id != updatedAvailability.AvailabilityId);
                    if (otherAvailabilityExists)
                        return new Result<dynamic>(ApiErrorCode.Conflict.ToString(), $"An availability for {weekDayValue} already exists for this doctor.");

                    // Updating the availability
                    availability.DayOfWeek = weekDayValue;
                    availability.FromTime = updatedAvailability.FromTime;
                    availability.ToTime = updatedAvailability.ToTime;
                    availability.AppointmentLength = updatedAvailability.AppointmentLength;
                    availability.IsActive = updatedAvailability.IsActive;

                    _dbContext.Entry(availability).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                    days.Add(weekDayValue.ToString());
                }

                // Commit transaction if all commands succeed.
                await transaction.CommitAsync();
                return new Result<dynamic>(new
                {
                    Days = days,
                    Message = $"Your availabilities have been successfully updated for the following days: {string.Join(", ", days)}."
                });
            }
            catch (Exception ex)
            {
                // Rollback transaction if exception occurred.
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while adding the availability: {ex.Message}");
            }
        }

        private async Task<(Doctor? doctor, string? error)> GetDoctorIdByDoctorUserOrStaff(string userId, string staffUserId)
        {
            // Try to get doctor by userId
            var doctor = await _dbContext.Doctors.FirstOrDefaultAsync(d => d.UserId == userId);

            if (doctor == null)
            {
                // If doctor not found, try to get staff and then get doctor by staff's DoctorId
                var staff = await _dbContext.DoctorStaffs.FirstOrDefaultAsync(s => s.UserId == staffUserId);
                if (staff != null)
                {
                    doctor = await _dbContext.Doctors.FirstOrDefaultAsync(d => d.Id == staff.DoctorId);
                }
            }

            // If doctor is still not found, return an error message
            if (doctor == null)
            {
                return (null, "Neither a doctor nor a staff member was found for the provided userId.");
            }

            return (doctor, null);
        }
    }
}
