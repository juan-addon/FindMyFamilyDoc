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

        public async Task<Result<DoctorAvailabilityViewModel>> AddAvailabilityAsync(DoctorAvailabilityViewModel newAvailability)
        {
            try
            {
                // Validate DayOfWeek enum
                _ = Enum.TryParse<WeekDay>(newAvailability.DayOfWeek, true, out var weekDayValue)
                ? weekDayValue
                : throw new ValidationException($"Invalid WeekDay value: {newAvailability.DayOfWeek}");

                // Validate if doctor exists

                var currentDoctor = await _dbContext.Doctors.FirstOrDefaultAsync(d => d.UserId == newAvailability.DoctorId);
                if (currentDoctor == null)
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");

                // Validate if doctor already has an availability for the same day
                var availabilityExists = await _dbContext.DoctorAvailabilities
                    .Include(m => m.Doctor)
                    .AnyAsync(a => a.Doctor.UserId == newAvailability.DoctorId && a.DayOfWeek == weekDayValue);
                if (availabilityExists)
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.Conflict.ToString(), "An availability for this day already exists for this doctor.");
                
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

                return new Result<DoctorAvailabilityViewModel>(newAvailability);
            }
            catch (Exception ex)
            {
                return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while adding the availability: {ex.Message}");
            }
        }

        public async Task<Result<DoctorAvailabilityViewModel>> UpdateAvailabilityAsync(DoctorAvailabilityViewModel updatedAvailability)
        {
            try
            {
                // Validate if availability exists
                var availability = await _dbContext.DoctorAvailabilities.FindAsync(updatedAvailability.AvailabilityId);
                if (availability == null)
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.NotFound.ToString(), "Availability not found.");

                // Validate DayOfWeek enum
                _ = Enum.TryParse<WeekDay>(updatedAvailability.DayOfWeek, true, out var weekDayValue)
                ? weekDayValue
                : throw new ValidationException($"Invalid WeekDay value: {availability.DayOfWeek}");

                // Validate if doctor exists
                var currentDoctor = await _dbContext.Doctors.FirstOrDefaultAsync(d => d.UserId == updatedAvailability.DoctorId);
                if (currentDoctor == null)
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");

                // Validate if doctor already has an availability for the same day (ignoring current)
                var otherAvailabilityExists = await _dbContext.DoctorAvailabilities
                    .AnyAsync(a => a.DoctorId == currentDoctor.Id &&
                                   a.DayOfWeek == weekDayValue &&
                                   a.Id != updatedAvailability.AvailabilityId);
                if (otherAvailabilityExists)
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.Conflict.ToString(), "An availability for this day already exists for this doctor.");

                // Updating the availability
                availability.DayOfWeek = weekDayValue;
                availability.FromTime = updatedAvailability.FromTime;
                availability.ToTime = updatedAvailability.ToTime;
                availability.AppointmentLength = updatedAvailability.AppointmentLength;
                availability.IsActive = updatedAvailability.IsActive;

                _dbContext.Entry(availability).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

                return new Result<DoctorAvailabilityViewModel>(updatedAvailability);
            }
            catch (Exception ex)
            {
                return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while updating the availability: {ex.Message}");
            }
        }
    }
}
