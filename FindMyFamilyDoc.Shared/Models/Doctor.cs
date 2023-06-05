using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    [Index(nameof(UserId), IsUnique = true, Name = "Unique_UserId_Doctor")]
    public class Doctor : BaseEntity
    {
        [Required]
        public string Title { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        public string MiddleName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string Phone { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string ContactInformation { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string Availability { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string WaitingTime { get; set; } = default!;

        public float Rating { get; set; }

        [Required]
        public decimal Fees { get; set; }

        public string ProfilePicture { get; set; } = default!;

        [Required]
        public bool IsAcceptingNewPatients { get; set; }


        public string UserId { get; set; } = default!;
        public User User { get; set; }

        // The city where the Doctor practices
        [Required]
        public int CityId { get; set; }
        public City City { get; set; }

        [Required]
        [StringLength(100)]
        public string Street { get; set; } = default!;

        [Required]
        [StringLength(10)]
        public string PostalCode { get; set; } = default!;

        public string Name => $"{FirstName} {LastName}".Trim();

        public ICollection<DoctorLanguage> DoctorLanguages { get; set; } = new List<DoctorLanguage>();

        public ICollection<DoctorEducationBackground> DoctorEducationBackgrounds { get; set; } = new List<DoctorEducationBackground>();

        public ICollection<DoctorExperience> Experiences { get; set; } = new List<DoctorExperience>();

        public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; } = new List<DoctorSpecialty>();
    }
}