using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.Business.Services
{
    public class DoctorStaffService : IDoctorStaffService
    {
        private readonly DatabaseContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public DoctorStaffService(DatabaseContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<Result<dynamic>> CreateStaff(StaffViewModel model)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                var (user, userCreationError) = await CreateUserAsync(model);
                if (!string.IsNullOrEmpty(userCreationError))
                {
                    await transaction.RollbackAsync();
                    return new Result<dynamic>(ApiErrorCode.BadRequest.ToString(), userCreationError);
                }

                var validationError = await ValidateModelAsync(model);
                if (!string.IsNullOrEmpty(validationError))
                {
                    await transaction.RollbackAsync();
                    return new Result<dynamic>(ApiErrorCode.BadRequest.ToString(), validationError);
                }

                var doctorId = await GetDoctorIdAsync(model.DoctorUserId);
                if (doctorId == null)
                {
                    await transaction.RollbackAsync();
                    return new Result<dynamic>(ApiErrorCode.NotFound.ToString(), "Doctor not found.");
                }

                var staff = await CreateDoctorStaffAsync(model, user!.Id, doctorId.Value);

                await transaction.CommitAsync();

                return new Result<dynamic>(new
                {
                    Staff = new
                    {
                        staff.FirstName,
                        staff.LastName,
                        staff.UserId,
                    },
                    Message = "Staff account has been successfully created."
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An unexpected error occurred while creating the staff: {ex.Message}");
            }
        }

        private async Task<(IdentityUser?, string?)> CreateUserAsync(StaffViewModel model)
        {
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.Phone,
                EmailConfirmed = true,
                IsPasswordChangeRequired = true
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return (null, $"Failed to create user: {string.Join(", ", result.Errors.Select(x => x.Description))}");
            }

            // Assign the staff role to the user
            var roleResult = await _userManager.AddToRoleAsync(user, UserRoles.AdministrativeAssistant.ToString());

            if (!roleResult.Succeeded)
            {
                return (null, $"Failed to assign role to user: {string.Join(", ", roleResult.Errors.Select(x => x.Description))}");
            }

            return (user, null);
        }

        private async Task<string> ValidateModelAsync(StaffViewModel model)
        {
            if (!await _dbContext.Doctors.AnyAsync(d => d.UserId == model.DoctorUserId))
                return "Doctor not found.";

            if (!await _dbContext.Cities.AnyAsync(c => c.Id == model.CityId))
                return "City not found.";

            return string.Empty;
        }

        private async Task<int?> GetDoctorIdAsync(string doctorUserId)
        {
            return await _dbContext.Doctors
                .Where(d => d.UserId == doctorUserId)
                .Select(d => d.Id)
                .SingleOrDefaultAsync();
        }

        private async Task<DoctorStaff> CreateDoctorStaffAsync(StaffViewModel model, string userId, int doctorId)
        {
            var staff = new DoctorStaff
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                ContactInformation = model.ContactInformation,
                Gender = Enum.TryParse(typeof(Gender), model.Gender, out var gender) ? (Gender)gender : throw new ArgumentException("Invalid gender"),
                DateOfBirth = model.DateOfBirth,
                DoctorId = doctorId,
                CityId = model.CityId,
                Street = model.Street,
                PostalCode = model.PostalCode,
                EmergencyContact = model.EmergencyContact,
                DateOfHire = model.DateOfHire,
                UserId = userId
            };

            _dbContext.DoctorStaffs.Add(staff);
            await _dbContext.SaveChangesAsync();
            return staff;
        }
    }
}