using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Security.Claims;
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
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // Check if the role exists
                if (await _roleManager.RoleExistsAsync(model.Role))
                {
                    var roleAssignResult = await _userManager.AddToRoleAsync(user, model.Role!.ToString());
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

        public async Task<IdentityResult> ConfirmEmailAsync(UserAccountConfirmationViewModel model)
        {
            var decodedUserId = HttpUtility.UrlDecode(model.UserId);
            //var decodedToken = HttpUtility.UrlDecode(token);

            var user = await _userManager.FindByIdAsync(decodedUserId);
            if (user == null)
            {
                throw new ArgumentException($"Unable to load user with ID '{model.UserId}'.");
            }

            if (user.EmailConfirmed)
            {
                throw new InvalidOperationException("Account is already confirmed.");
            }

            return await _userManager.ConfirmEmailAsync(user, model.Token);
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
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email!,
                Token = token,
                UserRefreshToken = userRefreshToken,
            });
        }

        public async Task LogoutAsync(ClaimsPrincipal currentUser)
        {
            var userId = currentUser.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                throw new ArgumentNullException("User Id not found in current user's claims.");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new ArgumentException($"No user found with Id {userId}.");
            }

            await _userManager.UpdateSecurityStampAsync(user);
            await _signInManager.SignOutAsync();
        }

        public async Task<string?> RefreshTokenAsync(RefreshTokenViewModel model)
        {
            var isValidRefreshToken = await _userRefreshTokenService.ValidateRefreshTokenAsync(model.UserId, model.RefreshToken);
            if (!isValidRefreshToken)
            {
                return null;
            }

            // Find the user
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                // Handle the case where the user was not found
                return null;
            }

            // Get the user's roles
            var roles = await _userManager.GetRolesAsync(user);
            if (roles == null || roles.Count == 0)
            {
                // Handle the case where the user has no roles
                return null;
            }

            // Generate a new JWT token
            var role = roles.FirstOrDefault();
            var newToken = JwtAuthenticationHelper.GenerateJwtToken(user, role!, _configuration);
            return newToken;
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
