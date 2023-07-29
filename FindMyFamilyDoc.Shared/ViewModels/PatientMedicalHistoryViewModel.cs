namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class PatientMedicalHistoryViewModel
    {
        public DateTime CreateDate { get; set; }
        public string PatientId { get; set; } = default!;
        public string PatientName { get; set; } = default!;
        public string DoctorId { get; set; } = default!;
        public string DoctorName { get; set; } = default!;
        public string Condition { get; set; } = default!;
        public string? Treatment { get; set; }
        public DateTime? DateOfTreatment { get; set; }
        public string? Notes { get; set; }
    }
}