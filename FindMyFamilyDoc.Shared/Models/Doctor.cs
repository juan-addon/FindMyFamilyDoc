namespace FindMyFamilyDoc.Shared.Models
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; } = default!;
        public virtual ICollection<DoctorSpecialty> DoctorSpecialties { get; set; }
    }
}
