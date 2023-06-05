using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
	[Table("Language")]
	public class Language : BaseEntity
	{
		[Required]
        [StringLength(100)]
        public string Name { get; set; } = default!;

		public ICollection<DoctorLanguage> DoctorLanguages { get; set; } = new List<DoctorLanguage>();
	}

}
