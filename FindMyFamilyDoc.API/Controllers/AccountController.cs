using FindMyFamilyDoc.API.Interfaces;
using FindMyFamilyDoc.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var (signInResult, result) = await _accountService.LoginAsync(model);

            if (signInResult.Succeeded)
            {
                return Ok(new { LoginResult = result });
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

    }
}
