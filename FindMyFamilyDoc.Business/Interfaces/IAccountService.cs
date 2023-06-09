using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUserAsync(RegisterViewModel user);
        Task<(SignInResult, LoginResultViewModel?)> LoginAsync(LoginViewModel model);
        Task<Result<IdentityResult>> ConfirmEmailAsync(UserAccountConfirmationViewModel model);
		Task<Result<string>> RefreshTokenAsync(RefreshTokenViewModel model);
        Task<Result<dynamic>> LogoutAsync(string userId);
		Task<Result<string>> ForgotPasswordAsync(ForgotPasswordViewModel model);
        Task<Result<string>> ConfirmResetPasswordTokenAsync(string userId, string token);
        Task<Result<string>> ResetPasswordAsync(ResetPasswordViewModel model);
	}
}
