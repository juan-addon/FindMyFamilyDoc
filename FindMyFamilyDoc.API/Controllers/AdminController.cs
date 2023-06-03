using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
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

        [HttpPost("approved-pending-doctor/{DoctorId}")]
        public async Task<IActionResult> ApprovedDoctor(int DoctorId)
        {
            var result = await _adminService.ApproveDoctor(DoctorId);
            return Result(result);
        }

        [HttpPost("pending-doctors")]
        public async Task<IActionResult> GetPendingDoctors()
        {
            var result = await _doctorService.GetDoctorsUnderReview();
            return Result(result);
        }
    }
}
