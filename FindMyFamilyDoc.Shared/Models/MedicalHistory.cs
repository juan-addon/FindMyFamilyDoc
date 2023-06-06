using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
    public class MedicalHistory: BaseEntity
    {
        [Required]
        public string Condition { get; set; } = default!;

        public string? Treatment { get; set; }


        public DateTime? DateOfTreatment { get; set; }

        [Required]
        public string Notes { get; set; } = default!;

        // Foreign key
        [ForeignKey("PatientMedicalHistory")]
        [Required]
        public string PatientId { get; set; }

        // Navigation property
        public Patient Patient { get; set; }
    }
}