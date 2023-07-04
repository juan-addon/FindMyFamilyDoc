namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class DoctorSearchViewModel
    {
        public List<string>? Specialties { get; set; }
        public List<string>? Languages { get; set; }
        //public Gender? Gender { get; set; }
        public string? PostalCode { get; set; }
        public List<string>? Cities { get; set; }
        public List<string>? States { get; set; }
    }
}