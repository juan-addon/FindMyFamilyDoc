using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.API.Models
{
    public class User : IdentityUser
    {

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; } = null!;

        public string Name => $"{FirstName} {LastName}".Trim();
    }
}
