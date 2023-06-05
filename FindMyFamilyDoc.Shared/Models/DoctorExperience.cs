using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
	public class DoctorExperience : BaseEntity
	{

		[Required]
        [StringLength(200)]
        public string CompanyName { get; set; } = default!;

		[Required]
		public string Description { get; set; } = default!;

		[Required]
		public DateTime StartDate { get; set; }

		public DateTime? EndDate { get; set; }

		[ForeignKey("Doctor")]
		public int DoctorId { get; set; }

		public Doctor Doctor { get; set; }
	}
}
