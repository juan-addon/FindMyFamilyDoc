﻿using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IDoctorAvailabilityService
    {
        Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetAvailabilityByDoctorIdAsync(string doctorId);
        Task<Result<IEnumerable<DoctorAvailabilityViewModel>>> GetDoctorAvailabilityByStaffIdAsync(string staffId);
        Task<Result<dynamic>> AddAvailabilityAsync(IEnumerable<DoctorAvailabilityViewModel> newAvailabilities);
        Task<Result<dynamic>> UpdateAvailabilityAsync(IEnumerable<DoctorAvailabilityViewModel> updatedAvailabilities);

        //Task<Result<bool>> DeleteAvailabilityAsync(int doctorId);
    }
}
