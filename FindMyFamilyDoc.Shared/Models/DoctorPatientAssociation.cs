using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class DoctorPatientAssociation
    {
        public int Id { get; set; }

        [Required]
        public string DoctorUserId { get; set; } = default!;
        public virtual Doctor Doctor { get; set; } = default!;

        [Required]
        public string PatientUserId { get; set; } = default!;
        public virtual Patient Patient { get; set; } = default!;

        public DateTime Timestamp { get; set; }

        public AssociationStatus Status { get; set; }

        public string ResultMessage { get; set; } = "";
    }
}
