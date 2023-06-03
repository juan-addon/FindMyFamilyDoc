using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
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

        public async Task<Result<dynamic>> ApproveDoctor(int id)
        {
            using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            try
            {
                var doctor = await _dbContext.Doctors.FirstOrDefaultAsync(m => m.Id == id);
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

                var result = await _userManager.AddToRoleAsync(user, "ApprovedDoctor");
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

    }
}
