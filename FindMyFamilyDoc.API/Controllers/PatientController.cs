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
    public class PatientController : BaseController
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost("create-patient")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> CreatePatient([FromBody] PatientViewModel model)
        {
            var result = await _patientService.CreatePatient(model);
            return Result(result);
        }

        [HttpPut("update-patient")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> UpdatePatient([FromBody] PatientViewModel model)
        {
            var result = await _patientService.UpdatePatient(model);
            return Result(result);
        }

        [HttpGet("get-patient-profile/{userId}")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> GetPatientProfile(string UserId)
        {
            var result = await _patientService.GetPatientProfile(UserId);
            return Result(result);
        }
    }
}
