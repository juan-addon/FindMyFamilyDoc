﻿using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace FindMyFamilyDoc.Business.Services
{
    public class AdminService : IAdminService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly DatabaseContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminService(UserManager<User> userManager, SignInManager<User> signInManager,
            DatabaseContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
            _roleManager = roleManager;
        }

        public async Task<Result<dynamic>> ApproveDoctor(string userId)
        {
            using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            try
            {
                var queryable = await QueryHelper.GetDoctorsUnderReviewQueryAsync(_dbContext);
                var doctor = await queryable.FirstOrDefaultAsync(m => m.UserId == userId);

                if (doctor == null)
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");

                var user = await _userManager.FindByIdAsync(doctor.UserId.ToString());
                if (user == null)
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "User not found.");

                var oldRoles = await _userManager.GetRolesAsync(user);
                var removeResult = await _userManager.RemoveFromRolesAsync(user, oldRoles);
                if (!removeResult.Succeeded)
                {
                    var errorMessage = string.Join(", ", removeResult.Errors.Select(e => e.Description));
                    return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"Failed to remove old roles: {errorMessage}");
                }

                var result = await _userManager.AddToRoleAsync(user, UserRoles.Doctor.ToString());
                if (!result.Succeeded)
                {
                    var errorMessage = string.Join(", ", result.Errors.Select(e => e.Description));
                    return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"Failed to update user role: {errorMessage}");
                }

                _dbContext.Doctors.Update(doctor);
                await _dbContext.SaveChangesAsync();

                transactionScope.Complete();

                return new Result<dynamic>(new
                {
                    Doctor = new
                    {
                        doctor.Name,
                        doctor.UserId,
                        doctor.Title
                    },
                    Message = "Doctor approved successfully."
                });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"Failed to approve doctor: {ex.Message}");
            }
        }

        public async Task<Result<dynamic>> RejectDoctor(DoctorRejectionViewModel model)
        {
            using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            try
            {
                var queryable = await QueryHelper.GetDoctorsUnderReviewQueryAsync(_dbContext);
                var doctor = await queryable.FirstOrDefaultAsync(m => m.UserId == model.UserId);

                if (doctor == null)
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");

                var user = await _userManager.FindByIdAsync(doctor.UserId.ToString());
                if (user == null)
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Doctor User Id not found.");

                var oldRoles = await _userManager.GetRolesAsync(user);
                var removeResult = await _userManager.RemoveFromRolesAsync(user, oldRoles);
                if (!removeResult.Succeeded)
                {
                    var errorMessage = string.Join(", ", removeResult.Errors.Select(e => e.Description));
                    return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"Failed to remove old roles: {errorMessage}");
                }

                var result = await _userManager.AddToRoleAsync(user, "DoctorRejected");
                if (!result.Succeeded)
                {
                    var errorMessage = string.Join(", ", result.Errors.Select(e => e.Description));
                    return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"Failed to update user role: {errorMessage}");
                }

                _dbContext.Doctors.Update(doctor);
                await _dbContext.SaveChangesAsync();

                // Create a new rejection record and add it to the database
                var rejection = new DoctorRejection { DoctorId = doctor.Id, Reason = model.RejectionReason };
                _dbContext.DoctorRejections.Add(rejection);
                await _dbContext.SaveChangesAsync();

                transactionScope.Complete();

                return new Result<dynamic>(new
                {
                    Doctor = new
                    {
                        doctor.Name,
                        doctor.UserId,
                        doctor.Title
                    },
                    Message = "Doctor has been rejected."
                });
            }
            catch (Exception ex)
            {
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"Failed to reject doctor: {ex.Message}");
            }
        }
    }
}
