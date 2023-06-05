﻿using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
	public interface IDoctorService
	{
        Task<Result<IEnumerable<dynamic>>> GetDoctors();
        Task<Result<IEnumerable<DoctorsUnderReviewViewModel>>> GetDoctorsUnderReview();
        Task<Result<DoctorDetailViewModel>> GetDoctorUnderReviewByUserId(string DoctorUserId);
		Task<Result<dynamic>> CreateDoctor(DoctorViewModel model);
        Task<Result<DoctorDetailViewModel>> GetDoctorProfile(string UserId);
    }
}