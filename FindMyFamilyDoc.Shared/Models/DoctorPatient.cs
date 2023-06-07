using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class DoctorPatient: BaseEntity
    {
        [Required]
        public int PatientId { get; set; }
        
        [Required]
        public int DoctorId { get; set; }
        public bool IsActive { get; set; }

        public Doctor Doctor { get; set; } = default!;

        public Patient Patient { get; set; } = default!;
    }
}