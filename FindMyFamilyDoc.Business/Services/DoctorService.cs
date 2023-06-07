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

		public async Task<Result<IEnumerable<dynamic>>> GetDoctors()
		{
			try
			{
				var doctors = await _dbContext.Doctors.ToListAsync();
				return new Result<IEnumerable<dynamic>>(doctors);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<dynamic>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving doctors: {ex.Message}");
			}
		}

        public async Task<Result<IEnumerable<DoctorsUnderReviewViewModel>>> GetDoctorsUnderReview()
        {
            try
            {

                var queryable = await QueryHelper.GetDoctorsUnderReviewQueryAsync(_dbContext);
                var doctorsUnderReview = await queryable
                     .Select(d => new DoctorsUnderReviewViewModel
                     {
                         DoctorId = d.Id,
                         DoctorUserId = d.UserId,
                         DoctorName = d.Name,
                         IsAcceptingNewPatients = d.IsAcceptingNewPatients,
                         Phone = d.Phone,
                         Title = d.Title,
                         Fees = d.Fees,
                         State = d.City.State.Name,
                         City = d.City.Name,
                         Address = d.Street,
                         PostalCode = d.PostalCode
                     })
                     .ToListAsync();

                return new Result<IEnumerable<DoctorsUnderReviewViewModel>>(doctorsUnderReview);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<DoctorsUnderReviewViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving doctors: {ex.Message}");
            }
        }

        public async Task<Result<DoctorDetailViewModel>> GetDoctorUnderReviewByUserId(string DoctorUserId)
		{
			try
			{
                var queryable = await QueryHelper.GetDoctorsUnderReviewQueryAsync(_dbContext);
                var doctor = await queryable
                    .Where(m => m.UserId == DoctorUserId)
                    .Select(d => new DoctorDetailViewModel
                    {
                        DoctorId = d.Id,
                        Title = d.Title,
                        Name = d.Name,
                        FirstName = d.FirstName,
                        LastName = d.LastName,
                        MiddleName = d.MiddleName,
                        Phone = d.Phone,
                        ContactInformation = d.ContactInformation,
                        WaitingTime = d.WaitingTime,
                        Fees = d.Fees,
                        ProfilePicture = d.ProfilePicture,
                        IsAcceptingNewPatients = d.IsAcceptingNewPatients,
                        UserId = d.UserId,
                        City = d.City.Name,
                        CityId= d.CityId,
                        State = d.City.State.Name,
                        StateId = d.City.StateId,
                        Street = d.Street,
                        PostalCode = d.PostalCode,
                        DoctorLanguages = d.DoctorLanguages.Select(dl => new DoctorDetailLanguageViewModel
                        {
                            LanguageId = dl.LanguageId,
                            LanguageName = dl.Language.Name // assuming the language name is available
                        }).ToList(),
                        DoctorEducationBackgrounds = d.DoctorEducationBackgrounds.Select(eb => new DoctorDetailEducationBackgroundViewModel
                        {
                            DoctorEducationBackgroundId = eb.Id,
                            InstitutionName = eb.InstitutionName,
                            Degree = eb.Degree,
                            FieldOfStudy = eb.FieldOfStudy,
                            StartDate = eb.StartDate,
                            EndDate = eb.EndDate
                        }).ToList(),
                        Experiences = d.Experiences.Select(e => new DoctorDetailExperienceViewModel
                        {
                            DoctorExperienceId = e.Id,
                            CompanyName = e.CompanyName,
                            Description = e.Description,
                            StartDate = e.StartDate,
                            EndDate = e.EndDate
                        }).ToList(),
                        DoctorSpecialties = d.DoctorSpecialties.Select(ds => new DoctorDetailSpecialtyViewModel
                        {
                            SpecialtyId = ds.SpecialtyId,
                            SpecialtyName = ds.Specialty.Name // assuming the specialty name is available
                        }).ToList()
                    }).FirstOrDefaultAsync();

                if (doctor != null)
					return new Result<DoctorDetailViewModel>(doctor);
				else
					return new Result<DoctorDetailViewModel>(ApiErrorCode.DataNotFound.ToString(), $"Doctor with UserID {DoctorUserId} not found.");
			}
			catch (Exception ex)
			{
				return new Result<DoctorDetailViewModel>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving the doctor: {ex.Message}");
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

        public async Task<Result<DoctorDetailViewModel>> GetDoctorProfile(string UserId)
        {
            try
            {
                var doctor = await _dbContext.Doctors
                    .Include(m => m.DoctorLanguages).ThenInclude(m => m.Language)
                    .Include(m => m.DoctorEducationBackgrounds)
                    .Include(m => m.Experiences)
                    .Include(m => m.DoctorSpecialties).ThenInclude(m => m.Specialty)
                    .Include(m => m.City).ThenInclude(m => m.State)
                    .FirstOrDefaultAsync(d => d.UserId == UserId);
                if (doctor == null)
                {
                    return new Result<DoctorDetailViewModel>(ApiErrorCode.NotFound.ToString(), "Doctor profile not found.");
                }

                var doctorDetailViewModel = new DoctorDetailViewModel
                    {
                        DoctorId = doctor.Id,
                        Title = doctor.Title,
                        Name = doctor.Name,
                        FirstName = doctor.FirstName,
                        LastName = doctor.LastName,
                        MiddleName = doctor.MiddleName,
                        Phone = doctor.Phone,
                        ContactInformation = doctor.ContactInformation,
                        //Availability = doctor.Availability,
                        WaitingTime = doctor.WaitingTime,
                        Fees = doctor.Fees,
                        ProfilePicture = doctor.ProfilePicture ?? string.Empty,
                        IsAcceptingNewPatients = doctor.IsAcceptingNewPatients,
                        UserId = doctor.UserId,
                        City = doctor.City.Name,
                        State = doctor.City.State.Name,
                        Street = doctor.Street,
                        PostalCode = doctor.PostalCode,
                        DoctorLanguages = doctor.DoctorLanguages.Select(dl => new DoctorDetailLanguageViewModel
                        {
                            LanguageId = dl.LanguageId,
                            LanguageName = dl.Language.Name // assuming the language name is available
                        }).ToList(),
                        DoctorEducationBackgrounds = doctor.DoctorEducationBackgrounds.Select(eb => new DoctorDetailEducationBackgroundViewModel
                        {
                            DoctorEducationBackgroundId = eb.Id,
                            InstitutionName = eb.InstitutionName,
                            Degree = eb.Degree,
                            FieldOfStudy = eb.FieldOfStudy,
                            StartDate = eb.StartDate,
                            EndDate = eb.EndDate
                        }).ToList(),
                        Experiences = doctor.Experiences.Select(e => new DoctorDetailExperienceViewModel
                        {
                            DoctorExperienceId = e.Id,
                            CompanyName = e.CompanyName,
                            Description = e.Description,
                            StartDate = e.StartDate,
                            EndDate = e.EndDate
                        }).ToList(),
                        DoctorSpecialties = doctor.DoctorSpecialties.Select(ds => new DoctorDetailSpecialtyViewModel
                        {
                            SpecialtyId = ds.SpecialtyId,
                            SpecialtyName = ds.Specialty.Name
                        }).ToList()
                    };

                return new Result<DoctorDetailViewModel>(doctorDetailViewModel);
            }
            catch (Exception ex)
            {
                return new Result<DoctorDetailViewModel>(ApiErrorCode.InternalServerError.ToString(), $"Failed to retrieve doctor profile: {ex.Message}");
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
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Phone = model.Phone,
                ContactInformation = model.ContactInformation,
                Availability = "No Defined",
                WaitingTime = model.WaitingTime,
                Fees = model.Fees,
                ProfilePicture = model.ProfilePicture ?? string.Empty,
                IsAcceptingNewPatients = model.IsAcceptingNewPatients,
                UserId = model.UserId,
                CityId = model.CityId,
                Street = model.Street,
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