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
    public class DoctorController : BaseController
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpPost("pending-doctors")]
        //[RoleAuthorize(UserRoles.Admin)]
        public async Task<IActionResult> GetPendingDoctors()
        {
            var result = await _doctorService.GetDoctorsUnderReview();
            return Result(result);
        }

        [HttpGet("pending-doctors/{id}")]
        //[RoleAuthorize(UserRoles.Admin)]
        public async Task<IActionResult> GetDoctorUnderReviewById(int id)
        {
            var result = await _doctorService.GetDoctorUnderReviewById(id);
            return Result(result);
        }

        [HttpPost("create-doctor")]
        [RoleAuthorize(UserRoles.DoctorUnderReview)]
        public async Task<IActionResult> CreateDoctor([FromBody] DoctorViewModel model)
        {
            var result = await _doctorService.CreateDoctor(model);
            return Result(result);
        }

        [HttpGet("doctor-profile/{id}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetDoctorProfileById(int id)
        {
            var result = await _doctorService.GetDoctorUnderReviewById(id);
            return Result(result);
        }
    }
}
