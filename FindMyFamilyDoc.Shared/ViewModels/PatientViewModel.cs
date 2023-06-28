using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class PatientViewModel: BaseUserViewModel
    {
        [Required]
        public string UserId { get; set; } = default!;
        public string EmergencyContact { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; } = default!;
        public string? ProfilePicture { get; set; }
    }

    public class PatientDetailViewModel : BaseUserViewModel
    {
        [Required]
        public string UserId { get; set; } = default!;
        public string ProfilePicture { get; set; } = default!;
        public string EmergencyContact { get; set; } = default!;
        public string CurrentMedications { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; } = default!;
        public string CityName { get; set; } = default!;
        public int StateId { get; set; } = default!;
        public string State { get; set; } = default!;
    }
}
