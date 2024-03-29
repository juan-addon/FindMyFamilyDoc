﻿using FindMyFamilyDoc.Business.Helpers;
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
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == UserId);
                if (user == null)
                {
                    return new Result<PatientDetailViewModel>(ApiErrorCode.NotFound.ToString(), "User not found.");
                }

                var patient = await _dbContext.Patients
                    .Include(p => p.City)
                    .ThenInclude(c => c.State)
                    .Include(c => c.DoctorPatientAssociations)
                    .ThenInclude(d => d.Doctor)
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
                        Occupation = p.Occupation,
                        AssociatedDoctor = p.DoctorPatientAssociations
                            .Where(dpa => dpa.Status == AssociationStatus.Approved)
                            .Select(dpa => new AssociatedDoctor
                            {
                                DoctorUserId = dpa.Doctor.UserId,
                                DoctorName = dpa.Doctor.Name
                            }).FirstOrDefault()
                    })
                    .FirstOrDefaultAsync();

                if (patient == null)
                {
                    return new Result<PatientDetailViewModel>(ApiErrorCode.NotFound.ToString(), "User needs to complete their profile.");
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
                var patient = await _dbContext.Patients.FirstOrDefaultAsync(m => m.UserId == model.UserId);

                if (patient == null)
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Patient not found.");
                }

                var validationError = await ValidatePatientUpdate(model);
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
                patient.MaritalStatus = Enum.TryParse<MaritalStatus>(model.MaritalStatus, true, out var maritalStatus)
                ? maritalStatus : throw new ValidationException($"Invalid Marital Status value: {model.MaritalStatus}");
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

        //create the get request list for patients, allow patients to delete a request in pending status...
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

        //create the get request list for patients, allow patients to delete a request in pending status...
        public async Task<Result<dynamic>> RequestDoctor(DoctorPatientRequestViewModel model)
        {
            try
            {
                // Check if patient already has an approved doctor
                var existingApprovedAssociation = await _dbContext.DoctorPatientAssociations
                    .FirstOrDefaultAsync(dpa => dpa.PatientUserId == model.PatientId && dpa.Status == AssociationStatus.Approved);
                if (existingApprovedAssociation != null)
                {
                    return new Result<dynamic>(ApiErrorCode.BadRequest.ToString(), "You already have an approved doctor.");
                }

                // Check if request already exists
                var existingRequest = await _dbContext.DoctorPatientAssociations
                    .FirstOrDefaultAsync(dpa => dpa.DoctorUserId == model.DoctorId && dpa.PatientUserId == model.PatientId && dpa.Status == AssociationStatus.Pending);
                if (existingRequest != null)
                {
                    return new Result<dynamic>(ApiErrorCode.Conflict.ToString(), "Request already exists.");
                }

                // Check if the doctor exists
                var doctor = await _dbContext.Doctors.FirstOrDefaultAsync(d => d.UserId == model.DoctorId);
                if (doctor == null)
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");
                }

                // Check if the patient exists
                var patient = await _dbContext.Patients.FirstOrDefaultAsync(p => p.UserId == model.PatientId);
                if (patient == null)
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Patient not found.");
                }

                // Check if patient has a pending request
                var patientPendingRequest = await _dbContext.DoctorPatientAssociations
                    .FirstOrDefaultAsync(dpa => dpa.PatientUserId == model.PatientId && dpa.Status == AssociationStatus.Pending);
                if (patientPendingRequest != null)
                {
                    return new Result<dynamic>(ApiErrorCode.RequestError.ToString(), "You already have a pending request. Please wait for the final decision before submitting another request.");
                }

                // Check if the doctor is under review
                //to-do
                /*var isUnderReview = await _dbContext.DoctorReviews.AnyAsync(dr => dr.DoctorUserId == model.DoctorId && dr.Status == ReviewStatus.UnderReview);
                if (isUnderReview)
                {
                    return new Result<dynamic>(ApiErrorCode.BadRequest.ToString(), "Doctor is currently under review.");
                }*/

                var newAssociation = new DoctorPatientAssociation
                {
                    DoctorUserId = model.DoctorId,
                    PatientUserId = model.PatientId,
                    Status = AssociationStatus.Pending,
                    Timestamp = DateTime.Now,
                };

                _dbContext.DoctorPatientAssociations.Add(newAssociation);
                await _dbContext.SaveChangesAsync();

                return new Result<dynamic>(new { Message = "Request sent." });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while requesting a doctor: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> DeletePendingRequestAsync(DeleteRequestViewModel model)
        {
            try
            {
                var request = await _dbContext.DoctorPatientAssociations
                    .FirstOrDefaultAsync(dpa => dpa.Id == model.RequestId && dpa.PatientUserId == model.PatientId && dpa.Status == AssociationStatus.Pending);

                if (request == null)
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Pending request not found or not owned by you.");
                }

                _dbContext.DoctorPatientAssociations.Remove(request);
                await _dbContext.SaveChangesAsync();

                return new Result<dynamic>(new { Message = "Pending request deleted." });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while deleting the pending request: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> GetRequestsForPatientAsync(string patientUserId)
        {
            try
            {
                var requests = await _dbContext.DoctorPatientAssociations
                    .Include(m => m.Doctor)
                    .Where(dpa => dpa.PatientUserId == patientUserId)
                    .ToListAsync();

                if (requests == null || !requests.Any())
                {
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "No requests found.");
                }

                var requestList = requests.Select(r => new
                {
                    RequestId = r.Id,
                    DoctorId = r.DoctorUserId,
                    DoctorName = r.Doctor.Name,
                    RequestDate = r.Timestamp,
                    RequestStatus = r.Status.ToString(),
                    RequestMessage = r.ResultMessage
                });

                return new Result<dynamic>(new { PatientRequests = requestList });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving the pending requests: {ex.Message}");
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

        private async Task<string> ValidatePatientUpdate(PatientViewModel model)
        {
            // Validate UserId
            var userExists = await _dbContext.Users.AnyAsync(u => u.Id == model.UserId);
            if (!userExists)
                return "User not found.";

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
                MaritalStatus = Enum.TryParse<MaritalStatus>(model.MaritalStatus, true, out var maritalStatus)
                ? maritalStatus : throw new ValidationException($"Invalid MaritalStatus value: {model.MaritalStatus}"),
                Occupation = model.Occupation
            };

            return patient;
        }
    }
}