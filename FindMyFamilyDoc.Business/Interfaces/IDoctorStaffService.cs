using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IDoctorStaffService
    {
        Task<Result<dynamic>> CreateStaff(StaffViewModel model);
    }
}
