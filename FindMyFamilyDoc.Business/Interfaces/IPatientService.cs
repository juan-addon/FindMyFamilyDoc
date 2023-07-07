using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IPatientService
    {
        Task<Result<dynamic>> CreatePatient(PatientViewModel model);
        Task<Result<dynamic>> UpdatePatient(PatientViewModel model);
        Task<Result<PatientDetailViewModel>> GetPatientProfile(string UserId);
        Task<Result<dynamic>> RequestDoctor(DoctorPatientRequestViewModel model);
        Task<Result<dynamic>> DeletePendingRequestAsync(DeleteRequestViewModel model);
        Task<Result<dynamic>> GetRequestsForPatientAsync(string patientUserId);
    }
}