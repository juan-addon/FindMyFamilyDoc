using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Patient : PersonBaseEntity
    {
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = default!;
        public Gender Gender { get; set; } = default!;
        public string EmergencyContact { get; set; } = default!;
        public string CurrentMedications { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; } = default!;

        [Required]
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}
