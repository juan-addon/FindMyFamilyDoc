using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Web;

namespace FindMyFamilyDoc.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly DatabaseContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IUserRefreshTokenService _userRefreshTokenService;
        private readonly IEmailService _emailService;

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager,
           DatabaseContext dbContext, RoleManager<IdentityRole> roleManager,
           IConfiguration configuration, IUserRefreshTokenService userRefreshTokenService,
           IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
            _roleManager = roleManager;
            _configuration = configuration;
            _userRefreshTokenService = userRefreshTokenService;
            _emailService = emailService;
        }

        public async Task<IdentityResult> CreateUserAsync(RegisterViewModel model)
        {
            await using var transaction = await _dbContext.Database.BeginTransactionAsync();
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // Check if the role exists
                if (await _roleManager.RoleExistsAsync(model.Role))
                {
                    var roleToAssign = model.Role.ToUpper() == UserRoles.Doctor.ToString().ToUpper()
						? UserRoles.DoctorUnderReview.ToString()
						: model.Role!.ToString();

                    var roleAssignResult = await _userManager.AddToRoleAsync(user, roleToAssign);

                    if (roleAssignResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        // Generate email confirmation token
                        var emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                        var userId = HttpUtility.UrlEncode(user.Id);
                        //var encodedEmailToken = HttpUtility.UrlEncode(emailConfirmationToken);
                        await SendEmailConfirmationAsync(user.Email, userId, emailConfirmationToken);

                        await transaction.CommitAsync();
                        //await transaction.RollbackAsync();
                    }
                    else
                    {
                        await transaction.RollbackAsync();
                        result = roleAssignResult;
                    }
                }
                else
                {
                    await transaction.RollbackAsync();
                    result = IdentityResult.Failed(new IdentityError { Description = "Role does not exist." });
                }
            }
            else
            {
                await transaction.RollbackAsync();
            }

            return result;
        }

		public async Task<Result<IdentityResult>> ConfirmEmailAsync(UserAccountConfirmationViewModel model)
		{
			try
			{
				var decodedUserId = HttpUtility.UrlDecode(model.UserId);

				var user = await _userManager.FindByIdAsync(decodedUserId);
				if (user == null)
				{
					return new Result<IdentityResult>(ApiErrorCode.UserNotFound.ToString(), $"Unable to load user with ID '{model.UserId}'.");
				}

				if (user.EmailConfirmed)
				{
					return new Result<IdentityResult>(ApiErrorCode.RequestError.ToString(), "Account is already confirmed.");
				}

				var result = await _userManager.ConfirmEmailAsync(user, model.Token);

				if (!result.Succeeded)
				{
					return new Result<IdentityResult>(ApiErrorCode.TokenInvalid.ToString(), "Failed to confirm user account.");
				}


				return new Result<IdentityResult>(result);
			}
			catch (Exception ex)
			{
				return new Result<IdentityResult>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<(SignInResult, LoginResultViewModel?)> LoginAsync(LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return (SignInResult.Failed, null);
            }

            // Check if the user has confirmed their email
            if (!user.EmailConfirmed)
            {
                return (SignInResult.NotAllowed, null);
            }

            // Check if the user is locked out
            if (await _userManager.IsLockedOutAsync(user))
            {
                return (SignInResult.LockedOut, null);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, lockoutOnFailure: false);
            var roles = await _userManager.GetRolesAsync(user);
            var role = roles.FirstOrDefault();

            if (role == null)
            {
                //throw new InvalidOperationException("User does not have a role assigned.");
                return (SignInResult.NotAllowed, null);
            }

            string doctorRejectionMessage = "";
            if (role == "DoctorRejected")
            {
                doctorRejectionMessage = _dbContext.DoctorRejections
                    .Include(m => m.Doctor).FirstOrDefault(m => m.Doctor.UserId == user.Id)?.Reason ?? string.Empty;
            }

            // Generate JWT token
            var token = JwtAuthenticationHelper.GenerateJwtToken(user, role, _configuration);
            var userRefreshToken = await _userRefreshTokenService.CreateRefreshTokenAsync(user.Id);

            return (result, new LoginResultViewModel
            {
                UserId = user.Id,
                Email = user.Email!,
                Token = token,
                Role = role,
				UserRefreshToken = userRefreshToken,
                IsPasswordChangeRequired = user.IsPasswordChangeRequired,
                IsProfileComplete = user.IsProfileComplete,
                DoctorRejectionReason = doctorRejectionMessage
            });
        }

		public async Task<Result<dynamic>> LogoutAsync(string userId)
		{
			try
			{
				if (string.IsNullOrEmpty(userId))
			    {
				    return new Result<dynamic>(ApiErrorCode.ValidationError.ToString(), "User Id is missing.");
			    }

			    var user = await _userManager.FindByIdAsync(userId);
			    if (user == null)
			    {
				    return new Result<dynamic>(ApiErrorCode.UserNotFound.ToString(), $"No user found with Id {userId}.");
			    }

			    await _userManager.UpdateSecurityStampAsync(user);
			    await _signInManager.SignOutAsync();
			    await _userRefreshTokenService.InvalidateRefreshTokenAsync(user.Id);

                return new Result<dynamic>(new
                {
                    User = new
                    {
                        user.Email,
                    },
                    Message = "You have been logged out."
                });
            }
            catch (Exception ex)
			{
				return new Result<dynamic>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<Result<string>> RefreshTokenAsync(RefreshTokenViewModel model)
		{
			var isValidRefreshToken = await _userRefreshTokenService.ValidateRefreshTokenAsync(model.UserId, model.RefreshToken);
			if (!isValidRefreshToken)
			{
				return new Result<string>(ApiErrorCode.ValidationError.ToString(), "Invalid refresh token.");
			}

			var user = await _userManager.FindByIdAsync(model.UserId);
			if (user == null)
			{
				return new Result<string>(ApiErrorCode.UserNotFound.ToString(), "User not found.");
			}

			var roles = await _userManager.GetRolesAsync(user);
			if (roles == null || roles.Count == 0)
			{
				return new Result<string>(ApiErrorCode.UserNotFound.ToString(), "User has no roles.");
			}

			var role = roles.FirstOrDefault();
			var newToken = JwtAuthenticationHelper.GenerateJwtToken(user, role!, _configuration);

			return new Result<string>(newToken);
		}

		public async Task<Result<string>> ForgotPasswordAsync(ForgotPasswordViewModel model)
		{
			try
			{
				var user = await _userManager.FindByEmailAsync(model.Email);
				if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
				{
					return new Result<string>(ApiErrorCode.UserNotFound.ToString(), "User not found or not confirmed");
				}
				var code = await _userManager.GeneratePasswordResetTokenAsync(user);
				await SendPasswordResetToken(model.Email, user.Id, code);
				return new Result<string>("Password reset process initiated successfully. Please check your email for further instructions.");
			}
			catch (Exception ex)
			{
				return new Result<string>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<Result<string>> ConfirmResetPasswordTokenAsync(string userId, string token)
		{
			try
			{
				var user = await _userManager.FindByIdAsync(userId);
				if (user == null)
				{
					return new Result<string>(ApiErrorCode.UserNotFound.ToString(), "User not found");
				}

				var isValidToken = await _userManager.VerifyUserTokenAsync(user, TokenOptions.DefaultProvider, "ResetPassword", token);
				if (!isValidToken)
				{
					return new Result<string>(ApiErrorCode.TokenInvalid.ToString(), "Invalid reset password token");
				}

				return new Result<string>(user.Id);
			}
			catch (Exception ex)
			{
				return new Result<string>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<Result<string>> ResetPasswordAsync(ResetPasswordViewModel model)
		{
			try
			{
				var user = await _userManager.FindByIdAsync(model.UserId);
				if (user == null)
				{
					return new Result<string>(ApiErrorCode.UserNotFound.ToString(), "User not found");
				}

				var isValidToken = await _userManager.VerifyUserTokenAsync(user, TokenOptions.DefaultProvider, "ResetPassword", model.Token);
				if (!isValidToken)
				{
					return new Result<string>(ApiErrorCode.TokenInvalid.ToString(), "Invalid reset password token");
				}

				var resetPasswordResult = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
				if (!resetPasswordResult.Succeeded)
				{
					var errors = resetPasswordResult.Errors.Select(error => error.Description);
					return new Result<string>(ApiErrorCode.RequestError.ToString(), "Password reset failed");
				}

				return new Result<string>("Password reset successful");
			}
			catch (Exception ex)
			{
				return new Result<string>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

        public async Task<Result<string>> ChangePasswordAsync(AccountChangePasswordInputModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return new Result<string>(ApiErrorCode.NotFound.ToString(), "User not found.");
            }

            var isOldPasswordCorrect = await _userManager.CheckPasswordAsync(user, model.OldPassword);
            if (!isOldPasswordCorrect)
            {
                return new Result<string>(ApiErrorCode.BadRequest.ToString(), "Invalid old password.");
            }

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (!changePasswordResult.Succeeded)
            {
                return new Result<string>(ApiErrorCode.BadRequest.ToString(), $"Failed to change password: {string.Join(", ", changePasswordResult.Errors.Select(x => x.Description))}");
            }

            // If the password was changed successfully, we can set the IsPasswordChangeRequired property to false
            user.IsPasswordChangeRequired = false;
            var updateResult = await _userManager.UpdateAsync(user);

            if (!updateResult.Succeeded)
            {
                return new Result<string>(ApiErrorCode.InternalServerError.ToString(), $"Failed to update user: {string.Join(", ", updateResult.Errors.Select(x => x.Description))}");
            }

            return new Result<string>("Password has been changed successfully.");
        }

        private async Task SendEmailConfirmationAsync(string email, string userId, string emailConfirmationToken)
        {
            var plainTextContent = $"<strong> User Id: {userId}</strong> Token: {emailConfirmationToken}";
            var htmlContent = $"<h2>Hello!</h2>" +
                  $"<p>Thank you for registering with us. To complete your registration, please confirm your email address.</p>" +
                  $"<p><strong>User Id: {userId}</strong></p>" +
                  $"<p>Confirmation Token: {emailConfirmationToken}</p>" +
                  $"<p>Click the link below to confirm your email:</p>" +
                  $"<a href='http://localhost:3000/auth/confirm-email?userId={userId}&token={emailConfirmationToken}'>" +
                  "Confirm Email Address" +
                  "</a>" +
                  "<p>If the above link does not work, copy and paste the entire URL into your browser.</p>" +
                  "<p>If you didn't request this, you can safely ignore this email.</p>" +
                  "<p>Best Regards,</p>" +
                  "<p>FindYourFamilyDoctor Team</p>";
            await _emailService.SendEmailAsync(email, "Confirm your email", plainTextContent, htmlContent);
        }

        private async Task SendPasswordResetToken(string email, string userId, string passwordResetToken)
        {
            var plainTextContent = $"User Id: {userId} Token: {passwordResetToken}";
            var htmlContent = $"<strong> User Id: {userId}</strong> Token: {passwordResetToken}";
            await _emailService.SendEmailAsync(email, "Reset your password", plainTextContent, htmlContent);
        }
    }
}