using Microsoft.AspNetCore.Identity;

namespace FindMyFamilyDoc.Shared.Models
{
    public class User : IdentityUser
    {
        public Patient Patient { get; set; } = default!;
        public Doctor Doctor { get; set; } = default!;
        public DoctorStaff Staff { get; set; } = default!;
    }
}
