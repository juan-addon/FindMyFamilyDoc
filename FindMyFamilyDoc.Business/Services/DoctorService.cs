using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.Business.Services
{
	public class DoctorService : IDoctorService
	{
		private readonly DatabaseContext _dbContext;

		public DoctorService(DatabaseContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Result<IEnumerable<Doctor>>> GetDoctors()
		{
			try
			{
				var doctors = await _dbContext.Doctors.ToListAsync();
				return new Result<IEnumerable<Doctor>>(doctors);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<Doctor>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving doctors: {ex.Message}");
			}
		}

		public async Task<Result<Doctor>> GetDoctorById(int id)
		{
			try
			{
				var doctor = await _dbContext.Doctors.FindAsync(id);
				if (doctor != null)
					return new Result<Doctor>(doctor);
				else
					return new Result<Doctor>(ApiErrorCode.DataNotFound.ToString(), $"Doctor with ID {id} not found.");
			}
			catch (Exception ex)
			{
				return new Result<Doctor>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving the doctor: {ex.Message}");
			}
		}

        public async Task<Result<Doctor>> CreateDoctor(DoctorViewModel model)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                var validationError = await ValidateDoctorCreation(model);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<Doctor>(ApiErrorCode.NotFound.ToString(), validationError);

                var doctor = MapViewModelToDoctor(model);

                // Add new doctor to context and save
                _dbContext.Doctors.Add(doctor);
                await _dbContext.SaveChangesAsync();

                await transaction.CommitAsync();

                return new Result<Doctor>(doctor);
            }
            catch (SqlException ex)
            {
                await transaction.RollbackAsync();
                return new Result<Doctor>(ApiErrorCode.InternalServerError.ToString(), $"A database error occurred while creating the doctor: {ex.Message}");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new Result<Doctor>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while creating the doctor: {ex.Message}");
            }
        }

        private async Task<string> ValidateDoctorCreation(DoctorViewModel model)
        {
            // Validate UserId
            var userExists = await _dbContext.Users.AnyAsync(u => u.Id == model.UserId);
            if (!userExists)
                return "User not found.";

            // Validate CityId
            var cityExists = await _dbContext.Cities.AnyAsync(c => c.Id == model.CityId);
            if (!cityExists)
                return "City not found.";

            // Validate DoctorLanguages
            var languageIds = model.DoctorLanguages.Select(l => l.LanguageId);
            var missingLanguageIds = await _dbContext.Languages
                .Where(l => languageIds.Contains(l.Id))
                .Select(l => l.Id)
                .Except(languageIds)
                .ToListAsync();
            if (missingLanguageIds.Any())
                return $"Languages with IDs {string.Join(", ", missingLanguageIds)} not found.";

            // Validate DoctorSpecialties
            var specialtyIds = model.DoctorSpecialties.Select(s => s.SpecialtyId);
            var missingSpecialtyIds = await _dbContext.Specialties
                .Where(s => specialtyIds.Contains(s.Id))
                .Select(s => s.Id)
                .Except(specialtyIds)
                .ToListAsync();
            if (missingSpecialtyIds.Any())
                return $"Specialties with IDs {string.Join(", ", missingSpecialtyIds)} not found.";

            return string.Empty; // No validation errors
        }

        private Doctor MapViewModelToDoctor(DoctorViewModel model)
        {
            var doctor = new Doctor
            {
                Title = model.Title,
                Name = model.Name,
                Phone = model.Phone,
                ContactInformation = model.ContactInformation,
                Availability = model.Availability,
                WaitingTime = model.WaitingTime,
                Fees = model.Fees,
                ProfilePicture = model.ProfilePicture ?? new byte[0],
                IsAcceptingNewPatients = model.IsAcceptingNewPatients,
                UserId = model.UserId,
                CityId = model.CityId,
                StreetNumber = model.StreetNumber,
                PostalCode = model.PostalCode
            };

            // Add DoctorLanguages
            doctor.DoctorLanguages = model.DoctorLanguages.Select(language => new DoctorLanguage
            {
                LanguageId = language.LanguageId
            }).ToList();

            // Add DoctorSpecialties
            doctor.DoctorSpecialties = model.DoctorSpecialties.Select(specialty => new DoctorSpecialty
            {
                SpecialtyId = specialty.SpecialtyId
            }).ToList();

            // Add DoctorEducationBackgrounds
            doctor.DoctorEducationBackgrounds = model.DoctorEducationBackgrounds.Select(education => new DoctorEducationBackground
            {
                InstitutionName = education.InstitutionName,
                Degree = education.Degree,
                FieldOfStudy = education.FieldOfStudy,
                StartDate = education.StartDate,
                EndDate = education.EndDate
            }).ToList();

            // Add DoctorExperiences
            doctor.Experiences = model.Experiences.Select(experience => new DoctorExperience
            {
                CompanyName = experience.CompanyName,
                Description = experience.Description,
                StartDate = experience.StartDate,
                EndDate = experience.EndDate
            }).ToList();

            return doctor;
        }
    }
}