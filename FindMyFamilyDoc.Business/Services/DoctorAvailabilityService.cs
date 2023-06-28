using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.Business.Services
{
    public class DoctorAvailabilityService : IDoctorAvailabilityService
    {
        private readonly DatabaseContext _dbContext;

        public DoctorAvailabilityService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetAvailabilityByDoctorIdAsync(int doctorId)
        {
            try
            {
                var availabilities = await _dbContext.DoctorAvailabilities
                    .Where(a => a.DoctorId == doctorId)
                    .ToListAsync();

                var availabilityViewModels = availabilities.Select(a => new DoctorAvailabilityViewModel
                {
                    AvailabilityId = a.Id,
                    DayOfWeek = a.DayOfWeek,
                    FromTime = a.FromTime,
                    ToTime = a.ToTime,
                    AppointmentLength = a.AppointmentLength,
                    DoctorId = a.DoctorId,
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
                var validationError = ValidateAvailabilityData(newAvailability);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.ValidationError.ToString(), validationError);

                // Validate if doctor exists
                if (!await CheckDoctorExistence(newAvailability.DoctorId))
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");

                // Validate if doctor already has an availability for the same day
                var availabilityExists = await _dbContext.DoctorAvailabilities.AnyAsync(a => a.DoctorId == newAvailability.DoctorId && a.DayOfWeek == newAvailability.DayOfWeek);
                if (availabilityExists)
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.Conflict.ToString(), "An availability for this day already exists for this doctor.");

                // Mapping and adding new availability
                var availability = new DoctorAvailability
                {
                    DayOfWeek = newAvailability.DayOfWeek,
                    FromTime = newAvailability.FromTime,
                    ToTime = newAvailability.ToTime,
                    AppointmentLength = newAvailability.AppointmentLength,
                    DoctorId = newAvailability.DoctorId,
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
                var validationError = ValidateAvailabilityData(updatedAvailability);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.ValidationError.ToString(), validationError);

                // Validate if doctor exists
                if (!await CheckDoctorExistence(updatedAvailability.DoctorId))
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");

                // Validate if doctor already has an availability for the same day (ignoring current)
                var otherAvailabilityExists = await _dbContext.DoctorAvailabilities
                    .AnyAsync(a => a.DoctorId == updatedAvailability.DoctorId &&
                                   a.DayOfWeek == updatedAvailability.DayOfWeek &&
                                   a.Id != updatedAvailability.AvailabilityId);
                if (otherAvailabilityExists)
                    return new Result<DoctorAvailabilityViewModel>(ApiErrorCode.Conflict.ToString(), "An availability for this day already exists for this doctor.");

                // Updating the availability
                availability.DayOfWeek = updatedAvailability.DayOfWeek;
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

        private string ValidateAvailabilityData(DoctorAvailabilityViewModel availability)
        {
            if (!Enum.IsDefined(typeof(WeekDay), availability.DayOfWeek))
                return $"Invalid DayOfWeek value: {availability.DayOfWeek}";

            // Additional validation rules specific to DoctorAvailability

            return string.Empty;
        }

        private async Task<bool> CheckDoctorExistence(int doctorId)
        {
            return await _dbContext.Doctors.AnyAsync(d => d.Id == doctorId);
        }
    }
}
