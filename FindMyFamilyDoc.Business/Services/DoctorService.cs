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

        public async Task<Result<dynamic>> CreateDoctor(DoctorViewModel model)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                var validationError = await ValidateDoctorCreation(model);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), validationError);

                var doctor = MapViewModelToDoctor(model);

                // Add new doctor to context and save
                _dbContext.Doctors.Add(doctor);
                await _dbContext.SaveChangesAsync();

                await transaction.CommitAsync();

                return new Result<dynamic>(new
                {
                    User = new
                    {
                        doctor.Name,
                        doctor.UserId,
                        doctor.Title
                    },
                    Message = "Your account has been created and your profile submitted. Please note that your profile must be approved by an administrator before you can fully access your account. Check your email for further updates."
                });
            }
            catch (SqlException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"A database error occurred while creating the doctor: {ex.Message}");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while creating the doctor: {ex.Message}");
            }
        }

        private async Task<string> ValidateDoctorCreation(DoctorViewModel model)
        {
            // Validate UserId
            var userExists = await _dbContext.Users.AnyAsync(u => u.Id == model.UserId);
            if (!userExists)
                return "User not found.";

            //Duplicate Doctor
            var doctorExists = await _dbContext.Doctors.AnyAsync(u => u.UserId == model.UserId);
            if (doctorExists)
                return "A Doctor profile already exists for this user. Each user can only have one Doctor profile.";

            // Validate CityId
            var cityExists = await _dbContext.Cities.AnyAsync(c => c.Id == model.CityId);
            if (!cityExists)
                return "City not found.";

            // Validate DoctorLanguages
            var languageIds = model.DoctorLanguages.Select(l => l.LanguageId);
            var dbLanguageIds = await _dbContext.Languages.Select(l => l.Id).ToListAsync();
            var missingLanguageIds = languageIds.Where(id => !dbLanguageIds.Contains(id)).ToList();
            if (missingLanguageIds.Any())
                return $"Languages with IDs {string.Join(", ", missingLanguageIds)} not found.";

            // Validate DoctorSpecialties
            var specialtyIds = model.DoctorSpecialties.Select(s => s.SpecialtyId);
            var dbSpecialtyIds = await _dbContext.Specialties.Select(s => s.Id).ToListAsync();
            var missingSpecialtyIds = specialtyIds.Where(id => !dbSpecialtyIds.Contains(id)).ToList();
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