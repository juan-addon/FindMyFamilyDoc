using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ApiKeyAuthFilter))]
    public class DoctorController : BaseController
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpPost("create-doctor")]
        [RoleAuthorize(UserRoles.DoctorUnderReview)]
        public async Task<IActionResult> CreateDoctor([FromBody] DoctorViewModel model)
        {
            var result = await _doctorService.CreateDoctor(model);
            return Result(result);
        }

        [HttpGet("doctor-underreview-info")]
        [RoleAuthorize(UserRoles.DoctorUnderReview)]
        public async Task<IActionResult> GetDoctorUnderReviewInfo(DoctorUserIdViewModel model)
        {
            var result = await _doctorService.GetDoctorUnderReviewByUserId(model.UserId);
            return Result(result);
        }

        [HttpGet("doctor-profile")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetDoctorProfile(DoctorUserIdViewModel model)
        {
            var result = await _doctorService.GetDoctorProfile(model.UserId);
            return Result(result);
        }
    }
}
