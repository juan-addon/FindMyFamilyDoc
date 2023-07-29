using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class LoginResultViewModel
    {
        public string UserId { get; set; } = default!;
        public string Email { get; set; } = default!;
		public string Role { get; set; } = default!;
		public string Token { get; set; } = default!;
        public string UserRefreshToken { get; set; } = default!;
        public bool IsPasswordChangeRequired { get; set; } = false;
        public bool IsProfileComplete { get; set; } = false;
        public string? DoctorRejectionReason { get; set; }
    }

    public class RefreshTokenViewModel
    {
        public string UserId { get; set; } = default!;
        public string ExpiredJwtToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = default!;
    }

	public class LogoutViewModel
	{
		public string UserId { get; set; } = default!;
	}

	public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "The password must be at least {2} characters long.", MinimumLength = 8)]
        public string Password { get; set; } = default!;

        [Required(ErrorMessage = "At least one role must be selected.")]
        public string Role { get; set; } = default!;
    }

    public class AccountChangePasswordInputModel : AccountSetPasswordInputModel
    {
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; } = default!;
    }

    public class UserAccountConfirmationViewModel
    {
        public string UserId { get; set; } = default!;
        public string Token { get; set; } = default!;
    }

    public class AccountSetPasswordInputModel
    {
        [Required]
        public string UserId { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters."), StringLength(100, ErrorMessage = "{0} cannot exceed {1} characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; } = default!;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare(nameof(NewPassword), ErrorMessage = "New password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = default!;
    }

	public class ForgotPasswordViewModel
	{
        [Required]
		[EmailAddress(ErrorMessage = "Invalid email address.")]
		public string Email { get; set; } = default!;
	}

	public class ResetPasswordViewModel
	{
		[Required]
		public string UserId { get; set; } = default!;
		[Required]
		public string Token { get; set; } = default!;
		[Required]
		public string NewPassword { get; set; } = default!;
	}
}