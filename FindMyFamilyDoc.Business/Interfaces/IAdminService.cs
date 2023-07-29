using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IAdminService
    {
        Task<Result<dynamic>> ApproveDoctor(string userId);
        Task<Result<dynamic>> RejectDoctor(DoctorRejectionViewModel model);
    }
}