﻿using FindMyFamilyDoc.API.Authentication;
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
        private readonly IDoctorStaffService _doctorStaffService;

        public DoctorController(IDoctorService doctorService, IDoctorStaffService doctorStaffService)
        {
            _doctorService = doctorService;
            _doctorStaffService = doctorStaffService;
        }

        [HttpPost("create-doctor")]
        [RoleAuthorize(UserRoles.DoctorUnderReview)]
        public async Task<IActionResult> CreateDoctor([FromBody] DoctorViewModel model)
        {
            var result = await _doctorService.CreateDoctor(model);
            return Result(result);
        }

        [HttpPut("update-doctor-profile")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> UpdateDoctor([FromBody] DoctorViewModel model)
        {
            var result = await _doctorService.UpdateDoctor(model);
            return Result(result);
        }

        [HttpGet("doctor-underreview-info/{userId}")]
        [RoleAuthorize(UserRoles.DoctorUnderReview)]
        public async Task<IActionResult> GetDoctorUnderReviewInfo(string userId)
        {
            var result = await _doctorService.GetDoctorUnderReviewByUserId(userId);
            return Result(result);
        }

        [HttpGet("doctor-profile/{userId}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetDoctorProfile(string userId)
        {
            var result = await _doctorService.GetDoctorProfile(userId);
            return Result(result);
        }

        [HttpPost("create-doctor-staff")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> CreateDoctorStaff([FromBody] StaffViewModel model)
        {
            var result = await _doctorStaffService.CreateStaff(model);
            return Result(result);
        }

        [HttpGet("doctor-staff/{doctorUserId}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetStaffByDoctorId(string doctorUserId)
        {
            var result = await _doctorStaffService.GetStaffByDoctorId(doctorUserId);
            return Result(result);
        }

        [HttpGet("get-patient-list/{doctorUserId}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetDoctorPatientList(string doctorUserId)
        {
            var result = await _doctorService.GetDoctorPatientListAsync(doctorUserId);
            return Result(result);
        }

        [HttpGet("get-patient-request-list/{doctorUserId}")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetPatientRequestAsyncByDoctorId(string doctorUserId)
        {
            var result = await _doctorService.GetPatientRequestAsyncByDoctorId(doctorUserId);
            return Result(result);
        }

        [HttpGet("get-patient-detail")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> GetRequestPatientDetail([FromQuery] DoctorPatientRequestViewModel model)
        {
            var result = await _doctorService.GetPatientDetail(model);
            return Result(result);
        }

        [HttpPut("process-patient-request")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> ProcessPatientRequest([FromBody] ProcessPatientRequestViewModel model)
        {
            var result = await _doctorService.ProcessPatientRequest(model);
            return Result(result);
        }

        [HttpDelete("delete-doctor-patient")]
        [RoleAuthorize(UserRoles.Doctor)]
        public async Task<IActionResult> DeleteDoctorPatient([FromBody] ProcessPatientRequestViewModel model)
        {
            var result = await _doctorService.DeleteDoctorPatient(model);
            return Result(result);
        }
    }
}