using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class StaffViewModel : BaseUserViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "The password must be at least {2} characters long.", MinimumLength = 8)]
        public string Password { get; set; } = default!;

        [Required]
        public string DoctorUserId { get; set; } = default!;
        
        public DateTime DateOfHire { get; set; }

        [Required]
        [StringLength(100)]
        public string EmergencyContact { get; set; } = default!;
    }

    public class StaffProfileUpdateViewModel
    {
        [Required]
        public string UserId { get; set; } = default!;

        [Required]
        public string FirstName { get; set; } = default!;
        public string MiddleName { get; set; } = default!;
        [Required]
        public string LastName { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string ContactInformation { get; set; } = default!;
        [Required]
        public string Gender { get; set; } = default!;
        [Required]
        public DateTime DateOfBirth { get; set; } = default!;

        [Required]
        public int CityId { get; set; } = default!;
        [Required]
        public string Street { get; set; } = default!;
        [Required]
        public string PostalCode { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string EmergencyContact { get; set; } = default!;
    }
}