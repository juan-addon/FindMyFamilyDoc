using FindMyFamilyDoc.Shared.Enums;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Specialty : BaseEntity
    {
        public string Name { get; set; } = default!;
        public SpecialtyStatus Status { get; set; } = SpecialtyStatus.Active;
        // This will automatically include all doctors with a given specialty
        public virtual ICollection<DoctorSpecialty> DoctorSpecialties { get; set; }
    }
}
