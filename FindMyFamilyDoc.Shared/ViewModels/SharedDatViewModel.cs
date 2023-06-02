namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class SpecialtyViewModel
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyName { get; set; } = default!;
    }

    public class StateViewModel
    {
        public int StateId { get; set; }
        public string StateName { get; set; } = default!;
    }

    public class LanguageViewModel
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; } = default!;
    }

    public class CityViewModel
    {
        public int CityId { get; set; }
        public string CityName { get; set; } = default!;
        public int StateId { get; set; }
    }
}