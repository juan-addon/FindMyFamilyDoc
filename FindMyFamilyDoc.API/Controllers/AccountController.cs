using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register")]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var result = await _accountService.CreateUserAsync(model);

            if (result.Succeeded)
            {
                return Result(Success(
					new
					{
						User = new
                        {
							model.FirstName,
                            model.LastName,
                            model.Email,
                            model.Role
						},
						Message = "Your account has been created. Please check your email for a confirmation link."
					}
				));
            }
            else
            {
                var errorMessages = result.Errors.Select(e => e.Description);
                return Result(Error<User>(ApiErrorCode.ValidationError, errorMessages));
            }
        }

		[HttpPut("confirm-email")]
		[ServiceFilter(typeof(ApiKeyAuthFilter))]
		public async Task<IActionResult> ConfirmEmail(UserAccountConfirmationViewModel model)
		{
			if (model.UserId == null || model.Token == null)
			{
				return Result(Error<User>(ApiErrorCode.Unauthorized, "User id and token are required."));
			}

			var result = await _accountService.ConfirmEmailAsync(model);

			if (!result.Success)
			{
				return Result(result);
			}

			return Result(Success(new
			{
				UserId = model.UserId,
				Message = "Your account has been activated."
			}));
		}

		[HttpPost("login")]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var (signInResult, result) = await _accountService.LoginAsync(model);

            if (signInResult.Succeeded)
            {
                return Result(Success(result));
            }
            else if (signInResult.IsLockedOut)
            {
                return Result(Error<User>(ApiErrorCode.UserLocked, "Account is locked out."));
            }
            else if (signInResult.IsNotAllowed)
            {
                return Result(Error<User>(ApiErrorCode.UserNotActivated, "Account is not allowed to login, please make sure that you activate your account."));
            }
            else
            {
                return Result(Error<User>(ApiErrorCode.InvalidCredentials, "Invalid login credentials."));
            }
        }

		[HttpPost("logout")]
		[ServiceFilter(typeof(ApiKeyAuthFilter))]
		public async Task<IActionResult> Logout(LogoutViewModel model)
		{
			if (string.IsNullOrEmpty(model.UserId))
			{
				return Result(Error<User>(ApiErrorCode.UserNotAuthenticated, "User is not authenticated."));
			}

			var result = await _accountService.LogoutAsync(model.UserId);
			return Result(result);
		}

		[HttpPost("forgot-password")]
		[ServiceFilter(typeof(ApiKeyAuthFilter))]
		public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
		{
			var result = await _accountService.ForgotPasswordAsync(model);
			return Result(result);
		}

		[HttpPost("confirm-reset-password-token")]
		[ServiceFilter(typeof(ApiKeyAuthFilter))]
		public async Task<IActionResult> ConfirmResetPasswordToken(UserAccountConfirmationViewModel model)
		{
			var result = await _accountService.ConfirmResetPasswordTokenAsync(model.UserId, model.Token);
			return Result(result);
		}

		[HttpPut("reset-password")]
		[ServiceFilter(typeof(ApiKeyAuthFilter))]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
		{
			var result = await _accountService.ResetPasswordAsync(model);
			return Result(result);
		}

		[HttpPost("refreshJwtToken")]
		[ServiceFilter(typeof(ApiKeyAuthFilter))]
		public async Task<IActionResult> RefreshToken(RefreshTokenViewModel model)
		{
			var result = await _accountService.RefreshTokenAsync(model);
			return Result(result);
		}
    }
}