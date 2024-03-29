﻿using System.ComponentModel.DataAnnotations;

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

        public string DoctorId { get; set; } = "";

        public string StaffId { get; set; } = "";

        public bool IsActive { get; set; } = true;
    }

    public class AvailabilityDeleteViewModel
    {
        [Required]
        public int AvailabilityId { get; set; }
    }

    public class AvailabilityCancellationViewModel : AvailabilityDeleteViewModel
    {

        [Required]
        public string CancellationMessage { get; set; } = "";
    }

}