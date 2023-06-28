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
    public class PatientService : IPatientService
    {
        private readonly DatabaseContext _dbContext;

        public PatientService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<PatientDetailViewModel>> GetPatientProfile(string UserId)
        {
            try
            {
                var patient = await _dbContext.Patients
                    .Include(p => p.City)
                    .ThenInclude(c => c.State)
                    .Where(p => p.UserId == UserId)
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

        public async Task<Result<dynamic>> UpdatePatient(PatientViewModel model)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                var patient = await _dbContext.Patients.FindAsync(model.UserId);

                if (patient == null)
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Patient not found.");
                }

                var validationError = await ValidatePatientCreation(model);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), validationError);

                // Update the patient details using the ViewModel
                patient.FirstName = model.FirstName;
                patient.MiddleName = model.MiddleName;
                patient.LastName = model.LastName;
                patient.Phone = model.Phone;
                patient.ContactInformation = model.ContactInformation;
                patient.ProfilePicture = model.ProfilePicture ?? string.Empty;
                patient.CityId = model.CityId;
                patient.Street = model.Street;
                patient.PostalCode = model.PostalCode;
                patient.DateOfBirth = model.DateOfBirth;
                patient.Gender = Enum.TryParse<Gender>(model.Gender, true, out var genderValue) ? genderValue : throw new ValidationException($"Invalid gender value: {model.Gender}");
                patient.EmergencyContact = model.EmergencyContact;
                patient.MaritalStatus = model.MaritalStatus;
                patient.Occupation = model.Occupation;

                // Update user profile completion status
                var user = await _dbContext.Users.FindAsync(patient.UserId);
                if (user != null)
                {
                    user.IsProfileComplete = true;
                    _dbContext.Entry(user).State = EntityState.Modified;
                }

                _dbContext.Entry(patient).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

                await transaction.CommitAsync();

                return new Result<dynamic>(new
                {
                    User = new
                    {
                        patient.FirstName,
                        patient.MiddleName,
                        patient.LastName,
                        patient.UserId,
                    },
                    Message = "Your profile has been updated successfully."
                });
            }
            catch (SqlException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"A database error occurred while updating the patient: {ex.Message}");
            }
            catch (ValidationException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.ValidationError.ToString(), ex.Message);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while updating the patient: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> CreatePatient(PatientViewModel model)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                // Assuming you have a method to validate the Patient's information similar to ValidateDoctorCreation()
                var validationError = await ValidatePatientCreation(model);
                if (!string.IsNullOrEmpty(validationError))
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), validationError);

                var patient = MapViewModelToPatient(model);

                // Assuming patient.UserId contains the associated User Id.
                var user = await _dbContext.Users.FindAsync(patient.UserId);
                if (user != null)
                {
                    user.IsProfileComplete = true;
                    _dbContext.Entry(user).State = EntityState.Modified;
                }

                // Add new patient to context and save
                _dbContext.Patients.Add(patient);
                await _dbContext.SaveChangesAsync();

                await transaction.CommitAsync();

                return new Result<dynamic>(new
                {
                    User = new
                    {
                        patient.FirstName,
                        patient.MiddleName,
                        patient.LastName,
                        patient.UserId,
                    },
                    Message = "Your account has been created and your profile is complete. You can now start using your account."
                });
            }
            catch (SqlException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"A database error occurred while creating the patient: {ex.Message}");
            }
            catch (ValidationException ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.ValidationError.ToString(), ex.Message);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while creating the patient: {ex.Message}");
            }
        }

        private async Task<string> ValidatePatientCreation(PatientViewModel model)
        {
            // Validate UserId
            var userExists = await _dbContext.Users.AnyAsync(u => u.Id == model.UserId);
            if (!userExists)
                return "User not found.";

            //Duplicate Patient
            var patientExists = await _dbContext.Patients.AnyAsync(p => p.UserId == model.UserId);
            if (patientExists)
                return "A Patient profile already exists for this user. Each user can only have one Patient profile.";

            // Validate CityId
            var cityExists = await _dbContext.Cities.AnyAsync(c => c.Id == model.CityId);
            if (!cityExists)
                return "City not found.";

            return string.Empty; // No validation errors
        }

        private Patient MapViewModelToPatient(PatientViewModel model)
        {
            var patient = new Patient
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Phone = model.Phone,
                ContactInformation = model.ContactInformation,
                ProfilePicture = model.ProfilePicture ?? string.Empty,
                UserId = model.UserId,
                CityId = model.CityId,
                Street = model.Street,
                PostalCode = model.PostalCode,
                DateOfBirth = model.DateOfBirth,
                Gender = Enum.TryParse<Gender>(model.Gender, true, out var genderValue)
                ? genderValue
                : throw new ValidationException($"Invalid gender value: {model.Gender}"),
                EmergencyContact = model.EmergencyContact,
                CurrentMedications = string.Empty,
                MaritalStatus = model.MaritalStatus,
                Occupation = model.Occupation
            };

            return patient;
        }
    }
}