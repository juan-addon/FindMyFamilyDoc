using FindMyFamilyDoc.Shared.Enums;

namespace FindMyFamilyDoc.Shared.Models
{
    public class AppointmentSlot
    {
        public WeekDay DayOfWeek { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
    }
}
