using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IDoctorAvailabilityService
    {
        Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetAvailabilityByDoctorIdAsync(string doctorId);
        Task<Result<DoctorAvailabilityViewModel>> AddAvailabilityAsync(DoctorAvailabilityViewModel newAvailability);
        Task<Result<DoctorAvailabilityViewModel>> UpdateAvailabilityAsync(DoctorAvailabilityViewModel updatedAvailability);
        //Task<Result<bool>> DeleteAvailabilityAsync(int doctorId);
    }
}
