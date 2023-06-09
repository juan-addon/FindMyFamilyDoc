using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
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

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager,
            DatabaseContext dbContext, RoleManager<IdentityRole> roleManager,
            IConfiguration configuration, IUserRefreshTokenService userRefreshTokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
            _roleManager = roleManager;
            _configuration = configuration;
            _userRefreshTokenService = userRefreshTokenService;
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


		private async Task SendPasswordResetToken(string email, string userId, string passwordResetToken)
		{
			var client = new SendGridClient("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");
			var from = new EmailAddress("juan.addon@gmail.com", "Jose Adon");
			var subject = "Reset your password";
			var to = new EmailAddress(email);
			var plainTextContent = $"User Id: {userId} Token: {passwordResetToken}";
			var htmlContent = $"<strong> User Id: {userId}</strong> Token: {passwordResetToken}";
			var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
			await client.SendEmailAsync(msg);
		}

		private async Task SendEmailConfirmationAsync(string email, string userId, string emailConfirmationToken)
        {
            var client = new SendGridClient("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");
            var from = new EmailAddress("juan.addon@gmail.com", "Jose Adon");
            var subject = "Confirm your email";
            var to = new EmailAddress(email);
            var plainTextContent = $"<strong> User Id: {userId}</strong> Token: {emailConfirmationToken}";
            var htmlContent = $"<strong> User Id: {userId}</strong> Token: {emailConfirmationToken}";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            await client.SendEmailAsync(msg);
        }
    }
}
