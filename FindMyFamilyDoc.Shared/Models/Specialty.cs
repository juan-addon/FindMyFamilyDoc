using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Specialty : BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; } = default!;
        public SpecialtyStatus Status { get; set; } = SpecialtyStatus.Active;
        public virtual ICollection<DoctorSpecialty> DoctorSpecialties { get; set; }
    }
}
