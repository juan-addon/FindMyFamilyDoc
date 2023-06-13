using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class BaseUserViewModel
    {
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
    }
}