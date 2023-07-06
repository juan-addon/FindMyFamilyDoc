using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
    public class DoctorPatientAssociation
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public string DoctorUserId { get; set; } = default!;
        public virtual Doctor Doctor { get; set; } = default!;

        [Required]
        [ForeignKey("Patient")]
        public string PatientUserId { get; set; } = default!;
        public virtual Patient Patient { get; set; } = default!;

        public DateTime Timestamp { get; set; }

        public AssociationStatus Status { get; set; }

        public string ResultMessage { get; set; } = "";
    }
}
