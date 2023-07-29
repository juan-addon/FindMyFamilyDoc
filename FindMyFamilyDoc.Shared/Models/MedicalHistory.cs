using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class MedicalHistory : BaseEntity
    {
        [Required]
        public string Condition { get; set; } = default!;

        public string? Treatment { get; set; }

        public DateTime? DateOfTreatment { get; set; }

        public string? Notes { get; set; } = default!;

        // Foreign keys
        [ForeignKey("PatientMedicalHistory")]
        [Required]
        public string PatientId { get; set; } = default!;

        [ForeignKey("Doctor")]
        [Required]
        public string DoctorId { get; set; } = default!;

        // Navigation properties
        public Patient Patient { get; set; } = default!;
        public Doctor Doctor { get; set; } = default!;
    }
}