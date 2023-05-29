using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
	public class DoctorLanguage: BaseEntity
	{
		[ForeignKey("Doctor")]
		public int DoctorId { get; set; }
		public Doctor Doctor { get; set; }

		[ForeignKey("Language")]
		public int LanguageId { get; set; }
		public Language Language { get; set; }
	}

}
