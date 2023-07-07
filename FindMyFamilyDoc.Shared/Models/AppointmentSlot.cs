namespace FindMyFamilyDoc.Shared.Models
{
    public class AppointmentSlot
    {
        public DateTime Date { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
    }
}
