using FindMyFamilyDoc.API.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace FindMyFamilyDoc.API.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUserAsync(RegisterViewModel user);
        Task<(SignInResult, LoginResultViewModel?)> LoginAsync(LoginViewModel model);
        Task LogoutAsync(ClaimsPrincipal currentUser);
        Task<IdentityResult> ConfirmEmailAsync(UserAccountConfirmationViewModel model);
    }
}
