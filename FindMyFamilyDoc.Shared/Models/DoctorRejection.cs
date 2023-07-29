using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
    public class DoctorRejection : BaseEntity
    {
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Required]
        public virtual Doctor Doctor { get; set; } = default!;

        [Required]
        public string Reason { get; set; } = default!;
    }
}