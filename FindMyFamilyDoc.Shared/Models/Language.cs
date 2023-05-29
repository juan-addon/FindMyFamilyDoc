using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyFamilyDoc.Shared.Models
{
	public class Language : BaseEntity
	{
		[Required]
		public string Name { get; set; } = default!;

		public ICollection<DoctorLanguage> DoctorLanguages { get; set; } = new List<DoctorLanguage>();
	}

}
