using Microsoft.AspNetCore.Identity;

namespace FindMyFamilyDoc.Shared.Models
{
    public class User : IdentityUser
    {
        public bool IsPasswordChangeRequired { get; set; } = false;
        public bool IsProfileComplete { get; set; } = false;
        public Patient Patient { get; set; } = default!;
        public Doctor Doctor { get; set; } = default!;
        public DoctorStaff Staff { get; set; } = default!;
    }
}