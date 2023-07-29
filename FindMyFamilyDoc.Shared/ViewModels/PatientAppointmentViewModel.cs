using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class PatientAppointmentViewModel
    {
        public int Id { get; set; } = 0;

        [Required]
        public string DoctorUserId { get; set; } = default!;

        [Required]
        public string PatientUserId { get; set; } = default!;

        [Required]
        public TimeSpan FromTime { get; set; }

        [Required]
        public TimeSpan ToTime { get; set; }

        public string? Status { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public DateTime RequestedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }

    public class AppointmentCancellationViewModel
    {
        [Required]
        public int AppointmentId { get; set; }

        [Required]
        public string DoctorUserId { get; set; } = default!;

        [Required]
        public string PatientUserId { get; set; } = default!;
    }

    public class AppointmentCompletionViewModel
    {
        [Required]
        public int AppointmentId { get; set; }
        [Required]
        public string DoctorUserId { get; set; } = default!;
        [Required]
        public MedicalHistoryViewModel MedicalHistory { get; set; } = new MedicalHistoryViewModel();
    }

    public class MedicalHistoryViewModel
    {
        [Required]
        public string Condition { get; set; } = default!;

        public string? Treatment { get; set; }

        public DateTime? DateOfTreatment { get; set; }

        public string? Notes { get; set; }
    }
}