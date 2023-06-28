using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IPatientService
    {
        Task<Result<dynamic>> CreatePatient(PatientViewModel model);
        Task<Result<dynamic>> UpdatePatient(PatientViewModel model);
        Task<Result<PatientDetailViewModel>> GetPatientProfile(string UserId);
    }
}