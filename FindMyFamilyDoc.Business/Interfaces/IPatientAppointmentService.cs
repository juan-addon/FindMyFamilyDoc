using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IPatientAppointmentService
    {
        Task<Result<PatientAppointmentViewModel>> CreatePatientAppointmentAsync(PatientAppointmentViewModel request);
        Task<Result<PatientAppointmentViewModel>> UpdatePatientAppointmentAsync(PatientAppointmentViewModel request);
        Task<Result<string>> CancelPatientAppointmentAsync(AppointmentCancellationViewModel request);
        Task<Result<List<PatientAppointmentViewModel>>> GetAppointmentsAsync(string userId, UserRoles userRole);
    }
}
