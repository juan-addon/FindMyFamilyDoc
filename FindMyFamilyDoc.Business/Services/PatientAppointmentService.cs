﻿using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Errors.Model;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Business.Services
{
    public class PatientAppointmentService : IPatientAppointmentService
    {
        private readonly DatabaseContext _dbContext;

        public PatientAppointmentService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<PatientAppointmentViewModel>> CreatePatientAppointmentAsync(PatientAppointmentViewModel request)
        {
            try
            {
                await ValidateAppointmentRequestAsync(request);

                var appointment = new PatientAppointment
                {
                    DoctorId = request.DoctorUserId,
                    PatientId = request.PatientUserId,
                    DayOfWeek = (WeekDay)Enum.Parse(typeof(WeekDay), request.AppointmentDate.DayOfWeek.ToString()),
                    FromTime = request.FromTime,
                    ToTime = request.ToTime,
                    Status = AppointmentStatus.Scheduled,
                    AppointmentDate = request.AppointmentDate,
                    StatusMessage = request.Status,
                    CreatedAt = DateTime.UtcNow, // assuming the request date is the current time
                };

                await _dbContext.PatientAppointments.AddAsync(appointment);
                await _dbContext.SaveChangesAsync();

                var viewModel = new PatientAppointmentViewModel
                {
                    Id = appointment.Id,
                    DoctorUserId = appointment.DoctorId,
                    PatientUserId = appointment.PatientId,
                    FromTime = appointment.FromTime,
                    ToTime = appointment.ToTime,
                    Status = appointment.Status.ToString(),
                    AppointmentDate = appointment.AppointmentDate,
                    RequestedDate = appointment.CreatedAt,
                };

                return new Result<PatientAppointmentViewModel>(viewModel);
            }
            catch (ValidationException ex)
            {
                return new Result<PatientAppointmentViewModel>(ApiErrorCode.ValidationError.ToString(), ex.Message);
            }
            catch (NotFoundException ex)
            {
                return new Result<PatientAppointmentViewModel>(ApiErrorCode.NotFound.ToString(), ex.Message);
            }
            catch (Exception ex)
            {
                return new Result<PatientAppointmentViewModel>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while creating the appointment: {ex.Message}");
            }
        }

        public async Task<Result<PatientAppointmentViewModel>> UpdatePatientAppointmentAsync(PatientAppointmentViewModel request)
        {
            try
            {
                await ValidateAppointmentRequestAsync(request);

                // Fetch the appointment to be updated
                var appointment = await _dbContext.PatientAppointments.FirstOrDefaultAsync(a => a.Id == request.Id);
                if (appointment == null)
                {
                    throw new NotFoundException("Appointment not found");
                }

                // Update appointment details
                appointment.DoctorId = request.DoctorUserId;
                appointment.PatientId = request.PatientUserId;
                appointment.DayOfWeek = (WeekDay)Enum.Parse(typeof(WeekDay), request.AppointmentDate.DayOfWeek.ToString());
                appointment.FromTime = request.FromTime;
                appointment.ToTime = request.ToTime;
                appointment.Status = AppointmentStatus.Rescheduled;
                appointment.AppointmentDate = request.AppointmentDate;
                appointment.UpdateAt = DateTime.UtcNow;
                appointment.StatusMessage = AppointmentStatus.Rescheduled.ToString();

                // Persist changes
                _dbContext.PatientAppointments.Update(appointment);
                await _dbContext.SaveChangesAsync();

                // Return the updated appointment
                var viewModel = new PatientAppointmentViewModel
                {
                    Id = appointment.Id,
                    DoctorUserId = appointment.DoctorId,
                    PatientUserId = appointment.PatientId,
                    FromTime = appointment.FromTime,
                    ToTime = appointment.ToTime,
                    Status = AppointmentStatus.Rescheduled.ToString(),
                    AppointmentDate = appointment.AppointmentDate,
                    RequestedDate = appointment.CreatedAt,
                    UpdatedDate = appointment.UpdateAt
                };

                return new Result<PatientAppointmentViewModel>(viewModel);
            }
            catch (ValidationException ex)
            {
                return new Result<PatientAppointmentViewModel>(ApiErrorCode.ValidationError.ToString(), ex.Message);
            }
            catch (NotFoundException ex)
            {
                return new Result<PatientAppointmentViewModel>(ApiErrorCode.NotFound.ToString(), ex.Message);
            }
            catch (Exception ex)
            {
                return new Result<PatientAppointmentViewModel>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while updating the appointment: {ex.Message}");
            }
        }

        public async Task<Result<string>> CancelPatientAppointmentAsync(AppointmentCancellationViewModel request)
        {
            try
            {
                // Fetch the appointment to be cancelled
                var appointment = await _dbContext.PatientAppointments.FirstOrDefaultAsync(a => a.Id == request.AppointmentId);
                if (appointment == null)
                {
                    throw new NotFoundException("Appointment not found");
                }

                // Verify the doctor and patient are correct
                if (appointment.DoctorId != request.DoctorUserId || appointment.PatientId != request.PatientUserId)
                {
                    throw new ValidationException("The provided DoctorId or PatientId does not match the appointment");
                }

                // Update appointment status to Cancelled
                appointment.Status = AppointmentStatus.Cancelled;
                appointment.StatusMessage = AppointmentStatus.Cancelled.ToString();
                appointment.UpdateAt = DateTime.UtcNow;

                // Persist changes
                _dbContext.PatientAppointments.Update(appointment);
                await _dbContext.SaveChangesAsync();

                return new Result<string>("Appointment successfully cancelled");
            }
            catch (ValidationException ex)
            {
                return new Result<string>(ApiErrorCode.ValidationError.ToString(), ex.Message);
            }
            catch (NotFoundException ex)
            {
                return new Result<string>(ApiErrorCode.NotFound.ToString(), ex.Message);
            }
            catch (Exception ex)
            {
                return new Result<string>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while cancelling the appointment: {ex.Message}");
            }
        }

        public async Task<Result<List<PatientAppointmentViewModel>>> GetAppointmentsAsync(string userId, UserRoles userRole)
        {
            try
            {
                var appointments = await _dbContext.PatientAppointments
                    .Where(a => userRole == UserRoles.Doctor ? a.DoctorId == userId : a.PatientId == userId )
                    .Select(a => new PatientAppointmentViewModel
                    {
                        Id = a.Id,
                        DoctorUserId = a.DoctorId,
                        PatientUserId = a.PatientId,
                        FromTime = a.FromTime,
                        ToTime = a.ToTime,
                        Status = a.Status.ToString(),
                        AppointmentDate = a.AppointmentDate,
                        RequestedDate = a.CreatedAt
                    })
                    .ToListAsync();

                return new Result<List<PatientAppointmentViewModel>>(appointments);
            }
            catch (Exception ex)
            {
                return new Result<List<PatientAppointmentViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred: {ex.Message}");
            }
        }

        public async Task<Result<string>> CompletePatientAppointmentAsync(AppointmentCompletionViewModel request)
        {
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    // Fetch the appointment to be completed
                    var appointment = await _dbContext.PatientAppointments.FirstOrDefaultAsync(a => a.Id == request.AppointmentId);
                    if (appointment == null)
                    {
                        throw new NotFoundException("Appointment not found");
                    }

                    // Validate appointment status
                    if (appointment.Status != AppointmentStatus.Scheduled && appointment.Status != AppointmentStatus.Rescheduled)
                    {
                        throw new ValidationException("The appointment status must be either Scheduled or Rescheduled to complete");
                    }

                    // Verify the doctor is correct
                    if (appointment.DoctorId != request.DoctorUserId)
                    {
                        throw new ValidationException("The provided DoctorId does not match the appointment");
                    }

                    // Update appointment status to Completed
                    appointment.Status = AppointmentStatus.Completed;
                    appointment.StatusMessage = AppointmentStatus.Completed.ToString();
                    appointment.UpdateAt = DateTime.UtcNow;

                    // Persist changes
                    _dbContext.PatientAppointments.Update(appointment);

                    // Add a new record to the patient's medical history
                    var medicalHistory = new MedicalHistory
                    {
                        Condition = request.MedicalHistory.Condition,
                        Treatment = request.MedicalHistory.Treatment,
                        DateOfTreatment = request.MedicalHistory.DateOfTreatment,
                        Notes = request.MedicalHistory.Notes ?? string.Empty,
                        PatientId = appointment.PatientId,
                        DoctorId = appointment.DoctorId
                    };

                    await _dbContext.PatientMedicalHistories.AddAsync(medicalHistory);
                    await _dbContext.SaveChangesAsync();

                    // All operations were successful, so commit the transaction.
                    await transaction.CommitAsync();

                    return new Result<string>("Appointment successfully completed and medical history updated");
                }
                catch (ValidationException ex)
                {
                    await transaction.RollbackAsync();
                    return new Result<string>(ApiErrorCode.ValidationError.ToString(), ex.Message);
                }
                catch (NotFoundException ex)
                {
                    await transaction.RollbackAsync();
                    return new Result<string>(ApiErrorCode.NotFound.ToString(), ex.Message);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return new Result<string>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while completing the appointment: {ex.Message}");
                }
            }
        }

        public async Task<Result<IList<PatientMedicalHistoryViewModel>>> GetPatientMedicalHistoryAsync(string patientId)
        {
            try
            {
                // Fetch medical history records
                var medicalHistories = await _dbContext.PatientMedicalHistories
                    .Include(m => m.Patient)
                    .Include(m => m.Doctor)
                    .Where(mh => mh.PatientId == patientId)
                    .Select(mh => new PatientMedicalHistoryViewModel
                    {
                        CreateDate = mh.CreatedAt,
                        PatientId = mh.PatientId,
                        PatientName = mh.Patient.Name,
                        DoctorId = mh.DoctorId,
                        DoctorName = mh.Doctor.Name,
                        Condition = mh.Condition,
                        Treatment = mh.Treatment,
                        DateOfTreatment = mh.DateOfTreatment,
                        Notes = mh.Notes
                    })
                    .OrderByDescending(mh => mh.CreateDate)
                    .ToListAsync();

                if (medicalHistories == null)
                {
                    return new Result<IList<PatientMedicalHistoryViewModel>>(new List<PatientMedicalHistoryViewModel>());
                }

                return new Result<IList<PatientMedicalHistoryViewModel>>(medicalHistories);
            }
            catch (Exception ex)
            {
                return new Result<IList<PatientMedicalHistoryViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while fetching the medical history: {ex.Message}");
            }
        }

        private async Task ValidateAppointmentRequestAsync(PatientAppointmentViewModel request)
        {
            var doctorExists = await _dbContext.Doctors.AnyAsync(d => d.UserId == request.DoctorUserId);
            if (!doctorExists)
            {
                throw new NotFoundException("Doctor not found");
            }

            var patientExists = await _dbContext.Patients.AnyAsync(p => p.UserId == request.PatientUserId);
            if (!patientExists)
            {
                throw new NotFoundException("Patient not found");
            }

            var patientIsAssociatedWithDoctor = await _dbContext.DoctorPatientAssociations.AnyAsync(dp => dp.Doctor.UserId == request.DoctorUserId && dp.Patient.UserId == request.PatientUserId && dp.Status == AssociationStatus.Approved);
            if (!patientIsAssociatedWithDoctor)
            {
                throw new ValidationException("Patient is not associated with the doctor");
            }

            var timeslotIsAvailable = await IsTimeslotAvailable(request.DoctorUserId, (WeekDay)Enum.Parse(typeof(WeekDay), request.AppointmentDate.DayOfWeek.ToString()), request.FromTime, request.ToTime);
            if (!timeslotIsAvailable)
            {
                throw new ValidationException("The requested timeslot is not available");
            }
        }

        private async Task<bool> IsTimeslotAvailable(string doctorId, WeekDay dayOfWeek, TimeSpan fromTime, TimeSpan toTime)
        {
            // Get the doctor's availability periods for the specific day
            var availabilities = await _dbContext.DoctorAvailabilities
                .Include(m => m.Doctor)
                .Where(da => da.Doctor.UserId == doctorId && da.DayOfWeek == dayOfWeek && da.IsActive)
                .ToListAsync();

            // Get the appointments for the doctor and day
            var appointments = await _dbContext.PatientAppointments
                .Where(a => a.DoctorId == doctorId && a.DayOfWeek == dayOfWeek && (a.Status == AppointmentStatus.Scheduled || a.Status == AppointmentStatus.Rescheduled))
                .ToListAsync();

            foreach (var availability in availabilities)
            {
                var slotStartTime = availability.FromTime;
                while (slotStartTime + availability.AppointmentLength <= availability.ToTime)
                {
                    var slotEndTime = slotStartTime + availability.AppointmentLength;

                    // Check if the desired timeslot matches this slot and if it's already booked
                    if (fromTime == slotStartTime && toTime == slotEndTime && !appointments.Any(a => a.FromTime == slotStartTime && a.ToTime == slotEndTime))
                    {
                        return true;
                    }

                    slotStartTime = slotEndTime;
                }
            }

            return false;
        }
    }
}