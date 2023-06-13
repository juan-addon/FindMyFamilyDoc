using FindMyFamilyDoc.Shared.Enums;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class PatientViewModel: BaseUserViewModel
    {
        public string EmergencyContact { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; } = default!;
    }
}
