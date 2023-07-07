using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
    [Index(nameof(UserId), IsUnique = true, Name = "Unique_UserId_Doctor")]
    public class Doctor : PersonBaseEntity
    {
        [Required]
        public string Title { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string WaitingTime { get; set; } = default!;

        public float Rating { get; set; }

        [Required]
        public decimal Fees { get; set; }

        [Required]
        public bool IsAcceptingNewPatients { get; set; }

        // 1:N relationship to Availability
        public ICollection<DoctorLanguage> DoctorLanguages { get; set; } = new List<DoctorLanguage>();

        // 1:N relationship to Availability
        public ICollection<DoctorEducationBackground> DoctorEducationBackgrounds { get; set; } = new List<DoctorEducationBackground>();

        // 1:N relationship to Availability
        public ICollection<DoctorExperience> Experiences { get; set; } = new List<DoctorExperience>();

        // 1:N relationship to Availability
        public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; } = new List<DoctorSpecialty>();

        // 1:N relationship to Staff
        public ICollection<DoctorStaff> DoctorStaffs { get; set; } = new List<DoctorStaff>();

        // 1:N relationship to Availability
        public ICollection<DoctorAvailability> DoctorAvailabilities { get; set; } = new List<DoctorAvailability>();

        [InverseProperty("Doctor")]
        public virtual ICollection<DoctorPatientAssociation> DoctorPatientAssociations { get; set; } = new List<DoctorPatientAssociation>();
    }
}