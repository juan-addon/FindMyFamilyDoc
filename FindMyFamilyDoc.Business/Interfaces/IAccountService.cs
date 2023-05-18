using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUserAsync(RegisterViewModel user);
        Task<(SignInResult, LoginResultViewModel?)> LoginAsync(LoginViewModel model);
        Task<IdentityResult> ConfirmEmailAsync(UserAccountConfirmationViewModel model);
        Task<string?> RefreshTokenAsync(RefreshTokenViewModel model);
        Task LogoutAsync(string userId);
    }
}
