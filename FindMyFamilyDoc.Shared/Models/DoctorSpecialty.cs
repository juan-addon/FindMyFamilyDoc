namespace FindMyFamilyDoc.Shared.Models
{
    public class DoctorSpecialty : BaseEntity
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = default!;

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = default!;
    }
}
