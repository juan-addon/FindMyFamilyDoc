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
    public class DoctorAvailabilityController : BaseController
    {
        private readonly IDoctorAvailabilityService _doctorAvailabilityService;

        public DoctorAvailabilityController(IDoctorAvailabilityService doctorAvailabilityService)
        {
            _doctorAvailabilityService = doctorAvailabilityService;
        }

        [HttpGet("get-doctor-availability/{doctorId}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetAvailabilityByDoctorIdAsync(string doctorId)
        {
            var result = await _doctorAvailabilityService.GetAvailabilityByDoctorIdAsync(doctorId);
            return Result(result);
        }

        [HttpPost("add-doctor-availability")]
        [RoleAuthorize(UserRoles.Doctor, UserRoles.AdministrativeAssistant)]
        public async Task<IActionResult> AddAvailabilityAsync([FromBody] IEnumerable<DoctorAvailabilityViewModel> models)
        {
            var result = await _doctorAvailabilityService.AddAvailabilityAsync(models);
            return Result(result);
        }

        [HttpPut("update-doctor-availability")]
        [RoleAuthorize(UserRoles.Doctor, UserRoles.AdministrativeAssistant)]
        public async Task<IActionResult> UpdateAvailabilityAsync([FromBody] IEnumerable<DoctorAvailabilityViewModel> models)
        {
            var result = await _doctorAvailabilityService.UpdateAvailabilityAsync(models);
            return Result(result);
        }
    }
}