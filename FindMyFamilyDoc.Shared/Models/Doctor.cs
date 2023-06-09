using FindMyFamilyDoc.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    [Index(nameof(UserId), IsUnique = true, Name = "Unique_UserId_Doctor")]
    public class Doctor : PersonBaseEntity
    {
        [Required]
        public string Title { get; set; } = default!;

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
        [StringLength(50)]
        public string WaitingTime { get; set; } = default!;

        public float Rating { get; set; }

        [Required]
        public decimal Fees { get; set; }

        public string ProfilePicture { get; set; } = default!;

        [Required]
        public bool IsAcceptingNewPatients { get; set; }
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;

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

        // 1:N relationship to DoctorLnaguages
        public ICollection<DoctorLanguage> DoctorLanguages { get; set; } = new List<DoctorLanguage>();

        // 1:N relationship to DoctorEducationBackgrounds
        public ICollection<DoctorEducationBackground> DoctorEducationBackgrounds { get; set; } = new List<DoctorEducationBackground>();

        // 1:N relationship to Experiences
        public ICollection<DoctorExperience> Experiences { get; set; } = new List<DoctorExperience>();

        // 1:N relationship to DoctorSpecialties
        public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; } = new List<DoctorSpecialty>();

        // 1:N relationship to DoctorStaffs
        public ICollection<DoctorStaff> DoctorStaffs { get; set; } = new List<DoctorStaff>();

        // 1:N relationship to DoctorAvailabilities
        public ICollection<DoctorAvailability> DoctorAvailabilities { get; set; } = new List<DoctorAvailability>();

        // 1:N relationship to Patients
        public ICollection<DoctorPatient> Patients { get; set; } = new List<DoctorPatient>();
    }
}