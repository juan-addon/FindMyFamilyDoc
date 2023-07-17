using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IDoctorAvailabilityService
    {
        Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetAvailabilityByDoctorIdAsync(string doctorId);
        Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetDoctorAvailabilityByStaffIdAsync(string staffId);
        Task<Result<dynamic>> AddAvailabilityAsync(IEnumerable<DoctorAvailabilityViewModel> newAvailabilities);
        Task<Result<dynamic>> UpdateAvailabilityAsync(IEnumerable<DoctorAvailabilityViewModel> updatedAvailabilities);
        Task<Result<List<AppointmentSlot>>> GetDoctorAvailabilitySlots(string doctorId, DateTime date);
        Task<Result<dynamic>> DeleteAvailabilityAndPatientAppointmentsAsync(AvailabilityCancellationViewModel request);
        Task<Result<dynamic>> DeleteAvailabilityAsync(int availabilityId);
    }
}