using System.ComponentModel.DataAnnotations;
using FindMyFamilyDoc.Shared.Enums;

namespace FindMyFamilyDoc.Shared.Models
{
    public class PatientAppointment : BaseEntity
    {
        [Required]
        public string DoctorId { get; set; } = default!;

        [Required]
        public string PatientId { get; set; } = default!;

        [Required]
        public WeekDay DayOfWeek { get; set; }

        [Required]
        public TimeSpan FromTime { get; set; }

        [Required]
        public TimeSpan ToTime { get; set; }

        [Required]
        public AppointmentStatus Status { get; set; }

        public Doctor Doctor { get; set; } = default!;
        public Patient Patient { get; set; } = default!;
    }
}