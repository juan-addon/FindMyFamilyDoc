using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
    public class DoctorStaff : PersonBaseEntity
    {
        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; } = default!;

        public DateTime DateOfHire { get; set; }
        public string Address { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string EmergencyContact { get; set; } = default!;
        public bool IsActive { get; set; } = true;

        // Navigation property
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Doctor Doctor { get; set; } = default!;
    }
}
