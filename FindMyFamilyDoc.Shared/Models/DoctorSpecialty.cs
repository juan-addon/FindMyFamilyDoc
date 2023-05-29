using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
    public class DoctorSpecialty : BaseEntity
    {
		[ForeignKey("Doctor")]
		public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = default!;

		[ForeignKey("Specialty")]
		public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = default!;
    }
}
