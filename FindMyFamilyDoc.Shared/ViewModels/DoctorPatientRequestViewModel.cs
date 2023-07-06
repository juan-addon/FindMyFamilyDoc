using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class DoctorPatientRequestViewModel
    {
        [Required]
        public string DoctorId { get; set; } = default!;

        [Required]
        public string PatientId { get; set; } = default!;
    }

    public class ProcessPatientRequestViewModel
    {
        [Required]
        public string DoctorId { get; set; } = default!;

        [Required]
        public string PatientId { get; set; } = default!;

        [Required]
        public string Status { get; set; } = default!;

        [Required]
        public string ResultMessage { get; set; } = default!;
    }
}
