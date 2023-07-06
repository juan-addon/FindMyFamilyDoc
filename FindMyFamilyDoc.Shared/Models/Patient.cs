using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Patient : PersonBaseEntity
    {
        public string EmergencyContact { get; set; } = default!;
        public string CurrentMedications { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; } = default!;

        [InverseProperty("Patient")]
        public virtual List<DoctorPatientAssociation>? DoctorPatientAssociations { get; set; }
    }
}
