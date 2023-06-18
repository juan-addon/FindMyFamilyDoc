using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IDoctorStaffService
    {
        Task<Result<dynamic>> CreateStaff(StaffViewModel model);
        Task<Result<dynamic>> UpdateStaffProfile(StaffProfileUpdateViewModel model);
        Task<Result<StaffProfileUpdateViewModel>> GetStaffProfileByUserId(string userId);
        Task<Result<IEnumerable<StaffProfileUpdateViewModel>>> GetStaffByDoctorId(string doctorId);
    }
}
