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
        public virtual ICollection<DoctorPatientAssociation> DoctorPatientAssociations { get; set; } = new List<DoctorPatientAssociation>();
        
        [InverseProperty("Patient")]
        public virtual ICollection<PatientAppointment> PatientAppointments { get; set; } = new List<PatientAppointment>();
    }
}
