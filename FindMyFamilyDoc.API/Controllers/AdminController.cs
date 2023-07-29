using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ApiKeyAuthFilter))]
    [RoleAuthorize(UserRoles.Admin)]
    public class AdminController : BaseController
    {
        private readonly IAdminService _adminService;
        private readonly IDoctorService _doctorService;

        public AdminController(IAdminService adminService, IDoctorService doctorService)
        {
            _adminService = adminService;
            _doctorService = doctorService;
        }

        [HttpPost("approved-pending-doctor")]
        public async Task<IActionResult> ApprovedDoctor(DoctorUserIdViewModel model)
        {
            var result = await _adminService.ApproveDoctor(model.UserId);
            return Result(result);
        }

        [HttpPost("reject-doctor")]
        public async Task<IActionResult> RejectDoctor(DoctorRejectionViewModel model)
        {
            var result = await _adminService.RejectDoctor(model);
            return Result(result);
        }

        [HttpGet("pending-doctors")]
        public async Task<IActionResult> GetPendingDoctors()
        {
            var result = await _doctorService.GetDoctorsUnderReview();
            return Result(result);
        }

        [HttpGet("rejected-doctors")]
        public async Task<IActionResult> GetRejectedDoctors()
        {
            var result = await _doctorService.GetRejectedDoctors();
            return Result(result);
        }

        [HttpGet("pending-doctor-detail/{userId}")]
        [RoleAuthorize(UserRoles.Admin)]
        public async Task<IActionResult> GetDoctorUnderReviewById(string userId)
        {
            var result = await _doctorService.GetDoctorUnderReviewByUserId(userId);
            return Result(result);
        }
    }
}
