using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.API.Interfaces;
using FindMyFamilyDoc.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
                return Success(new { result });
            }
            else
            {
                var errorMessages = result.Errors.Select(e => e.Description);
                return Error(errorMessages);
            }
        }

        [HttpPut("ConfirmEmail")]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public async Task<IActionResult> ConfirmEmail(UserAccountConfirmationViewModel model)
        {
            if (model.UserId == null || model.Token == null)
            {
                return Error("User id and token are required.");
            }

            try
            {
                var result = await _accountService.ConfirmEmailAsync(model);
                if (!result.Succeeded)
                {
                    return Error("Error confirming email.");
                }
            }
            catch (ArgumentException ex)
            {
                return Error(ex.Message);
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }

            return Success("Email confirmed successfully.");
        }

        [HttpPost("login")]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var (signInResult, result) = await _accountService.LoginAsync(model);

            if (signInResult.Succeeded)
            {
                return Success(new { LoginResult = result });
            }
            else if (signInResult.IsLockedOut)
            {
                return StatusCode(423, "Account is locked out");
            }
            else
            {
                return Error("Invalid login credentials");
            }
        }

        [HttpPost("refreshJwtToken")]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public async Task<IActionResult> RefreshJwtToken(RefreshTokenViewModel model)
        {
            var newToken = await _accountService.RefreshTokenAsync(model);

            if (newToken.IsNullOrEmpty())
            {
                return Error("Invalid refresh token.");
            }

            return Success(new
            {
                Token = newToken
            });
        }

    }
}
