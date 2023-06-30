using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class DoctorAvailabilityViewModel
    {
        public int? AvailabilityId { get; set; }

        [Required]
        public string DayOfWeek { get; set; } = default!;

        [Required]
        public TimeSpan FromTime { get; set; }

        [Required]
        public TimeSpan ToTime { get; set; }

        [Required]
        public TimeSpan AppointmentLength { get; set; }

        [Required]
        public string DoctorId { get; set; } = default!;

        public bool IsActive { get; set; } = true;
    }
}