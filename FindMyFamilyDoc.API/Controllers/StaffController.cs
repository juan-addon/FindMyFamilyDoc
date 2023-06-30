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
    public class StaffController : BaseController
    {
        private readonly IDoctorStaffService _doctorStaffService;

        public StaffController(IDoctorStaffService doctorStaffService)
        {
            _doctorStaffService = doctorStaffService;
        }

        [HttpPut("update-staff-profile")]
        [RoleAuthorize(UserRoles.AdministrativeAssistant)]
        public async Task<IActionResult> UpdateStaffProfile([FromBody] StaffProfileUpdateViewModel model)
        {
            var result = await _doctorStaffService.UpdateStaffProfile(model);
            return Result(result);
        }

        [HttpGet("staff-profile/{staffUserId}")]
        [RoleAuthorize(UserRoles.AdministrativeAssistant)]
        public async Task<IActionResult> GetStaffProfile(string staffUserId)
        {
            var result = await _doctorStaffService.GetStaffProfileByUserId(staffUserId);
            return Result(result);
        }
    }
}
