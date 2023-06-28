using FindMyFamilyDoc.Shared.Enums;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Patient : PersonBaseEntity
    {
        public string EmergencyContact { get; set; } = default!;
        public string CurrentMedications { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; } = default!;
    }
}
