using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
	public class DoctorEducationBackground
	{
		public int Id { get; set; }

		[Required]
        [StringLength(200)]
        public string InstitutionName { get; set; } = default!;

		[Required]
        [StringLength(200)]
        public string Degree { get; set; } = default!;

		[Required]
        [StringLength(200)]
        public string FieldOfStudy { get; set; } = default!;

		[Required]
		public DateTime StartDate { get; set; }

		public DateTime? EndDate { get; set; }

		[ForeignKey("Doctor")]
		public int DoctorId { get; set; }
		public Doctor Doctor { get; set; }
	}
}
