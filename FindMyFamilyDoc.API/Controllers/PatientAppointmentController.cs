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
    public class PatientAppointmentController : BaseController
    {
        private readonly IPatientAppointmentService _patientAppointmentService;
        private readonly IDoctorAvailabilityService _doctorAvailabilityService;

        public PatientAppointmentController(IPatientAppointmentService patientAppointmentService, IDoctorAvailabilityService doctorAvailabilityService)
        {
            _patientAppointmentService = patientAppointmentService;
            _doctorAvailabilityService = doctorAvailabilityService;
        }

        [HttpPost("request-appointment")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> PatientAppointmentViewModel([FromBody] PatientAppointmentViewModel model)
        {
            var result = await _patientAppointmentService.CreatePatientAppointmentAsync(model);
            return Result(result);
        }

        [HttpPut("update-appointment")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> UpdatePatientAppointmentAsync([FromBody] PatientAppointmentViewModel model)
        {
            var result = await _patientAppointmentService.UpdatePatientAppointmentAsync(model);
            return Result(result);
        }

        [HttpDelete("cancel-appointment")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> CancelPatientAppointmentAsync([FromBody] AppointmentCancellationViewModel model)
        {
            var result = await _patientAppointmentService.CancelPatientAppointmentAsync(model);
            return Result(result);
        }

        [HttpGet("get-patient-appointment/{patientUserId}")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> GetPatientAppointmentsAsync(string patientUserId)
        {
            var result = await _patientAppointmentService.GetAppointmentsAsync(patientUserId, UserRoles.Patient);
            return Result(result);
        }

        [HttpGet("get-pending-appointment-doctor/{doctorUserId}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetDoctorAppointmentsAsync(string doctorUserId)
        {
            var result = await _patientAppointmentService.GetAppointmentsAsync(doctorUserId, UserRoles.Doctor);
            return Result(result);
        }

        [HttpGet("get-doctor-availability-slots/{doctorUserId}/{appoitmentDate}")]
        [RoleAuthorize(UserRoles.Patient)]
        public async Task<IActionResult> GetDoctorAvailabilitySlots(string doctorUserId, DateTime appoitmentDate)
        {
            var result = await _doctorAvailabilityService.GetDoctorAvailabilitySlots(doctorUserId, appoitmentDate);
            return Result(result);
        }
    }
}
