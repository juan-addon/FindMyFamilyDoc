using FindMyFamilyDoc.Shared.Enums;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Specialty : BaseEntity
    {
        public string Name { get; set; } = default!;
        public SpecialtyStatus Status { get; set; } = SpecialtyStatus.Active;
        public virtual ICollection<DoctorSpecialty> DoctorSpecialties { get; set; }
    }
}
