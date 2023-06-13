using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class PersonBaseEntity : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = default!;

        [StringLength(50)]
        public string MiddleName { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = default!;

        [Required]
        [StringLength(20)]
        public string Phone { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string ContactInformation { get; set; } = default!;

        [Required]
        public Gender Gender { get; set; } = default!;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int CityId { get; set; }
        public City City { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string Street { get; set; } = default!;

        [Required]
        [StringLength(10)]
        public string PostalCode { get; set; } = default!;

        public string ProfilePicture { get; set; } = default!;

        public string Name => $"{FirstName} {LastName}".Trim();

        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}