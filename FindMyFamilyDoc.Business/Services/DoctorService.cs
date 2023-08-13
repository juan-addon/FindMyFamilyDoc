using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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

        public async Task<Result<IEnumerable<DoctorsUnderReviewViewModel>>> GetRejectedDoctors()
        {
            try
            {
                var queryable = await QueryHelper.GetRejectedDoctorsQuery(_dbContext);
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
                    .Include(m => m.DoctorLanguages).ThenInclude(m => m.Language)
                    .Include(m => m.DoctorEducationBackgrounds)
                    .Include(m => m.Experiences)
                    .Include(m => m.DoctorSpecialties).ThenInclude(m => m.Specialty)
                    .Include(m => m.City).ThenInclude(m => m.State)
                    .FirstOrDefaultAsync();

                if (doctor != null)
                    return new Result<DoctorDetailViewModel>(MapDoctorToDoctorDetailViewModel(doctor));
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
                var validationError = await ValidateDoctor(model, false);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), validationError);

                var doctor = MapViewModelToDoctor(model);

                var user = await _dbContext.Users.FindAsync(doctor.UserId);
                if (user != null)
                {
                    user.IsProfileComplete = true;
                    _dbContext.Entry(user).State = EntityState.Modified;
                }

                _dbContext.Doctors.Add(doctor); // Add new doctor to context and save
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
            catch (ValidationException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.ValidationError.ToString(), ex.Message);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while creating the doctor: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> UpdateDoctor(DoctorViewModel model)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                var validationError = await ValidateDoctor(model, true);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), validationError);

                // Get the doctor and related data from the database
                var doctor = await _dbContext.Doctors
                    .Include(d => d.DoctorLanguages)
                    .Include(d => d.DoctorSpecialties)
                    .Include(d => d.DoctorEducationBackgrounds)
                    .Include(d => d.Experiences)
                    .FirstOrDefaultAsync(m => m.UserId == model.UserId);

                if (doctor == null)
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");

                // Map changes from the ViewModel to the existing doctor entity
                doctor = MapViewModelToDoctor(model, doctor);

                // Update the doctor entity and its related entities manually
                _dbContext.Update(doctor);

                foreach (var item in doctor.DoctorLanguages)
                {
                    if (item.Id == 0)
                        _dbContext.Entry(item).State = EntityState.Added;
                    else
                        _dbContext.Entry(item).State = EntityState.Modified;
                }

                foreach (var item in doctor.DoctorSpecialties)
                {
                    if (item.Id == 0)
                        _dbContext.Entry(item).State = EntityState.Added;
                    else
                        _dbContext.Entry(item).State = EntityState.Modified;
                }

                foreach (var item in doctor.DoctorEducationBackgrounds)
                {
                    if (item.Id == 0)
                        _dbContext.Entry(item).State = EntityState.Added;
                    else
                        _dbContext.Entry(item).State = EntityState.Modified;
                }

                foreach (var item in doctor.Experiences)
                {
                    if (item.Id == 0)
                        _dbContext.Entry(item).State = EntityState.Added;
                    else
                        _dbContext.Entry(item).State = EntityState.Modified;
                }

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
                    Message = "Your account has been updated."
                });
            }
            catch (SqlException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"A database error occurred while updating the doctor: {ex.Message}");
            }
            catch (ValidationException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.ValidationError.ToString(), ex.Message);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while updating the doctor: {ex.Message}");
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

                var doctorDetailViewModel = MapDoctorToDoctorDetailViewModel(doctor);

                return new Result<DoctorDetailViewModel>(doctorDetailViewModel);
            }
            catch (Exception ex)
            {
                return new Result<DoctorDetailViewModel>(ApiErrorCode.InternalServerError.ToString(), $"Failed to retrieve doctor profile: {ex.Message}");
            }
        }

        public async Task<Result<List<DoctorDetailViewModel>>> SearchDoctor(DoctorSearchViewModel searchModel)
        {
            try
            {
                IQueryable<Doctor> query = _dbContext.Doctors
                    .Include(m => m.DoctorLanguages).ThenInclude(m => m.Language)
                    .Include(m => m.DoctorEducationBackgrounds)
                    .Include(m => m.Experiences)
                    .Include(m => m.DoctorSpecialties).ThenInclude(m => m.Specialty)
                    .Include(m => m.City).ThenInclude(m => m.State);

                if (searchModel.Specialties != null && searchModel.Specialties.Any())
                {
                    query = query.Where(d => d.DoctorSpecialties.Any(ds => searchModel.Specialties.Contains(ds.Specialty.Name)));
                }

                if (searchModel.Languages != null && searchModel.Languages.Any())
                {
                    query = query.Where(d => d.DoctorLanguages.Any(dl => searchModel.Languages.Contains(dl.Language.Name)));
                }

				if (!string.IsNullOrEmpty(searchModel.PostalCode) && searchModel.PostalCode.Length >= 1)
				{
					var postalCodeStart = searchModel.PostalCode.Substring(0, 1);
					query = query.Where(d => d.PostalCode.StartsWith(postalCodeStart));
				}

				if (searchModel.Cities != null && searchModel.Cities.Any())
                {
                    query = query.Where(d => searchModel.Cities.Contains(d.City.Name));
                }

                if (searchModel.States != null && searchModel.States.Any())
                {
                    query = query.Where(d => searchModel.States.Contains(d.City.State.Name));
                }

                var doctors = await query.Where(m => m.IsAcceptingNewPatients).ToListAsync();
                var doctorViewModels = doctors.Select(MapDoctorToDoctorDetailViewModel).ToList();

                if (!doctorViewModels.Any())
                {
                    return new Result<List<DoctorDetailViewModel>>(ApiErrorCode.NotFound.ToString(), "No doctors found matching the specified criteria.");
                }

                return new Result<List<DoctorDetailViewModel>>(doctorViewModels);
            }
            catch (Exception ex)
            {
                return new Result<List<DoctorDetailViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"Failed to search doctors: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> GetDoctorPatientListAsync(string doctorId)
        {
            return await GetDoctorPatientDataAsync(doctorId, AssociationStatus.Approved, "No Patients found.");
        }

        public async Task<Result<dynamic>> GetPatientRequestAsyncByDoctorId(string doctorId)
        {
            return await GetDoctorPatientDataAsync(doctorId, AssociationStatus.Pending, "No Request found.");
        }

        public async Task<Result<PatientDetailViewModel>> GetPatientDetail(DoctorPatientRequestViewModel model)
        {
            try
            {
                var patientAssociation = await _dbContext.DoctorPatientAssociations
                    .FirstOrDefaultAsync(dpa => dpa.DoctorUserId == model.DoctorId && dpa.PatientUserId == model.PatientId && dpa.Status != AssociationStatus.Rejected);

                if(patientAssociation == null)
                {
                    return new Result<PatientDetailViewModel>(ApiErrorCode.NotFound.ToString(), "Patient not found.");
                }

                var patient = await _dbContext.Patients
                    .Include(p => p.City)
                    .ThenInclude(c => c.State)
                    .Where(p => p.UserId == model.PatientId)
                    .Select(p => new PatientDetailViewModel
                    {
                        UserId = p.UserId,
                        FirstName = p.FirstName,
                        MiddleName = p.MiddleName,
                        LastName = p.LastName,
                        Phone = p.Phone,
                        ContactInformation = p.ContactInformation,
                        ProfilePicture = p.ProfilePicture,
                        CityId = p.CityId,
                        CityName = p.City.Name,
                        StateId = p.City.State.Id,
                        State = p.City.State.Name,
                        Street = p.Street,
                        PostalCode = p.PostalCode,
                        DateOfBirth = p.DateOfBirth,
                        Gender = p.Gender.ToString(),
                        EmergencyContact = p.EmergencyContact,
                        CurrentMedications = p.CurrentMedications,
                        MaritalStatus = p.MaritalStatus,
                        Occupation = p.Occupation
                    })
                    .FirstOrDefaultAsync();

                if (patient == null)
                {
                    return new Result<PatientDetailViewModel>(ApiErrorCode.NotFound.ToString(), "Patient not found.");
                }

                return new Result<PatientDetailViewModel>(patient);
            }
            catch (Exception ex)
            {
                return new Result<PatientDetailViewModel>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving the patient profile: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> DeleteDoctorPatient(ProcessPatientRequestViewModel model)
        {
            try
            {
                var association = await GetDoctorPatientAssociationAsync(model.DoctorId, model.PatientId, AssociationStatus.Approved);
                if (association == null)
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Request not found.");
                }

                if (!IsValidStatus(model.Status))
                {
                    return new Result<dynamic>(ApiErrorCode.ValidationError.ToString(), "Invalid status value.");
                }

                await SaveChangesAsync(association, model, AssociationStatus.Deleted);

                return new Result<dynamic>(new { Message = "Patient Deleted." });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while processing a patient request: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> ProcessPatientRequest(ProcessPatientRequestViewModel model)
        {
            try
            {
                var association = await GetDoctorPatientAssociationAsync(model.DoctorId, model.PatientId, AssociationStatus.Pending);
                if (association == null)
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Request not found.");
                }

                if (!IsValidStatus(model.Status))
                {
                    return new Result<dynamic>(ApiErrorCode.ValidationError.ToString(), "Invalid status value.");
                }

                var status = Enum.Parse<AssociationStatus>(model.Status);
                var message = status == AssociationStatus.Approved ? "Patient approved." : "Patient rejected.";

                if (status != AssociationStatus.Approved)
                {
                    _dbContext.DoctorPatientAssociations.Remove(association);
                }

                await SaveChangesAsync(association, model, status);

                return new Result<dynamic>(new { Message = message });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while processing a patient request: {ex.Message}");
            }
        }

        private async Task<DoctorPatientAssociation?> GetDoctorPatientAssociationAsync(string doctorId, string patientId, AssociationStatus status)
        {
            return await _dbContext.DoctorPatientAssociations
                .FirstOrDefaultAsync(dpa => dpa.DoctorUserId == doctorId && dpa.PatientUserId == patientId && dpa.Status == status);
        }

        private bool IsValidStatus(string status)
        {
            return Enum.TryParse(status, out AssociationStatus _);
        }

        private async Task SaveChangesAsync(DoctorPatientAssociation association, ProcessPatientRequestViewModel model, AssociationStatus status)
        {
            association.Status = status;
            association.Timestamp = DateTime.Now;
            association.ResultMessage = model.ResultMessage;

            _dbContext.Entry(association).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        private async Task<string> ValidateDoctor(DoctorViewModel model, bool isUpdate = false)
        {
            // Validate UserId
            var userExists = await _dbContext.Users.AnyAsync(u => u.Id == model.UserId);
            if (!userExists)
                return "User not found.";

            // Validate Doctor existence for update, check for duplicates during creation
            var doctorExists = await _dbContext.Doctors.AnyAsync(u => u.UserId == model.UserId);
            if (isUpdate)
            {
                if (!doctorExists)
                    return "Doctor profile not found for this user.";
            }
            else
            {
                if (doctorExists)
                    return "A Doctor profile already exists for this user. Each user can only have one Doctor profile.";
            }

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

        private Doctor MapViewModelToDoctor(DoctorViewModel model, Doctor? doctor = null)
        {
            doctor = doctor ?? new Doctor();

            // Map fields from model to doctor
            doctor.Title = model.Title;
            doctor.FirstName = model.FirstName;
            doctor.MiddleName = model.MiddleName;
            doctor.LastName = model.LastName;
            doctor.Phone = model.Phone;
            doctor.ContactInformation = model.ContactInformation;
            doctor.WaitingTime = model.WaitingTime;
            doctor.Fees = model.Fees;
            doctor.ProfilePicture = model.ProfilePicture ?? string.Empty;
            doctor.IsAcceptingNewPatients = model.IsAcceptingNewPatients;
            doctor.UserId = model.UserId;
            doctor.CityId = model.CityId;
            doctor.Street = model.Street;
            doctor.PostalCode = model.PostalCode;
            doctor.DateOfBirth = model.DateOfBirth;
            doctor.Gender = Enum.TryParse<Gender>(model.Gender, true, out var genderValue)
                ? genderValue
                : throw new ValidationException($"Invalid gender value: {model.Gender}");

            // Replace collections if they exist or create new ones
            UpdateCollection(doctor.DoctorLanguages,
                m => m.DoctorLanguages.Select(l => new DoctorLanguage { LanguageId = l.LanguageId }),
                model);

            UpdateCollection(doctor.DoctorSpecialties,
                m => m.DoctorSpecialties.Select(s => new DoctorSpecialty { SpecialtyId = s.SpecialtyId }),
                model);

            UpdateCollection(doctor.DoctorEducationBackgrounds,
                m => m.DoctorEducationBackgrounds.Select(e => new DoctorEducationBackground
                {
                    InstitutionName = e.InstitutionName,
                    Degree = e.Degree,
                    FieldOfStudy = e.FieldOfStudy,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate
                }),
                model);

            UpdateCollection(doctor.Experiences,
                m => m.Experiences.Select(e => new DoctorExperience
                {
                    CompanyName = e.CompanyName,
                    Description = e.Description,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate
                }),
                model);

            return doctor;
        }

        private DoctorDetailViewModel MapDoctorToDoctorDetailViewModel(Doctor doctor)
        {
            return new DoctorDetailViewModel
            {
                DoctorId = doctor.Id,
                Title = doctor.Title,
                Name = doctor.Name,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                MiddleName = doctor.MiddleName,
                Phone = doctor.Phone,
                ContactInformation = doctor.ContactInformation,
                WaitingTime = doctor.WaitingTime,
                Fees = doctor.Fees,
                ProfilePicture = doctor.ProfilePicture,
                IsAcceptingNewPatients = doctor.IsAcceptingNewPatients,
                UserId = doctor.UserId,
                CityName = doctor.City.Name,
                CityId = doctor.CityId,
                State = doctor.City.State.Name,
                StateId = doctor.City.StateId,
                Street = doctor.Street,
                PostalCode = doctor.PostalCode,
                Gender = doctor.Gender.ToString(),
                DateOfBirth = doctor.DateOfBirth,
                DoctorLanguages = doctor.DoctorLanguages.Select(dl => new DoctorDetailLanguageViewModel
                {
                    LanguageId = dl.LanguageId,
                    LanguageName = dl.Language.Name
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
        }

        private void UpdateCollection<T>( ICollection<T> existingCollection, Func<DoctorViewModel, IEnumerable<T>> newCollectionSelector, DoctorViewModel model)
        {
            existingCollection = existingCollection ?? new List<T>();
            existingCollection.Clear();

            foreach (var item in newCollectionSelector(model))
            {
                existingCollection.Add(item);
            }
        }

        private async Task<Result<dynamic>> GetDoctorPatientDataAsync(string doctorId, AssociationStatus status, string notFoundMessage)
        {
            try
            {
                var patients = await _dbContext.DoctorPatientAssociations
                    .Include(m => m.Patient)
                    .ThenInclude(m => m.City)
                    .ThenInclude(m => m.State)
                    .Where(dpa => dpa.DoctorUserId == doctorId && dpa.Status == status)
                    .ToListAsync();

                if (patients == null || !patients.Any())
                {
                    return new Result<dynamic>(new { DoctorPatientsList = patients, Message = notFoundMessage });
                }

                var transformedPatients = patients.Select(p => new
                {
                    PatientId = p.Patient.UserId,
                    PatientName = p.Patient.Name,
                    Gender = p.Patient.Gender.ToString(),
                    MaritalStatus = p.Patient.MaritalStatus.ToString(),
                    Occupation = p.Patient.Occupation.ToString(),
                    Direction = $"{p.Patient.Street} {p.Patient.City.Name} {p.Patient.City.State.Name} {p.Patient.PostalCode}"
                });

                return new Result<dynamic>(new { DoctorPatientsList = transformedPatients, Message = "Ok" });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while processing a patient request: {ex.Message}");
            }
        }
    }
}