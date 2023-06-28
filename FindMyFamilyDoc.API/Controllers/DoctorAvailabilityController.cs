using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Business.Services;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ApiKeyAuthFilter))]
    public class DoctorAvailabilityController : BaseController
    {
        private readonly IDoctorAvailabilityService _doctorAvailabilityService;

        public DoctorAvailabilityController(IDoctorAvailabilityService doctorAvailabilityService)
        {
            _doctorAvailabilityService = doctorAvailabilityService;
        }

        [HttpGet("get-doctor-availability/{doctorId}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetAvailabilityByDoctorIdAsync(int doctorId)
        {
            var result = await _doctorAvailabilityService.GetAvailabilityByDoctorIdAsync(doctorId);
            return Result(result);
        }

        [HttpPost("add-doctor-availability")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> AddAvailabilityAsync([FromBody] DoctorAvailabilityViewModel model)
        {
            var result = await _doctorAvailabilityService.AddAvailabilityAsync(model);
            return Result(result);
        }

        [HttpPut("update-doctor-availability")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> UpdateAvailabilityAsync([FromBody] DoctorAvailabilityViewModel model)
        {
            var result = await _doctorAvailabilityService.UpdateAvailabilityAsync(model);
            return Result(result);
        }
    }
}