namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class DoctorDetailViewModel
    {
        public int DoctorId { get; set; } 
        public string Title { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string ContactInformation { get; set; } = default!;
        public string Availability { get; set; } = default!;
        public int WaitingTime { get; set; }
        public decimal Fees { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public bool IsAcceptingNewPatients { get; set; } = false;
        public string UserId { get; set; } = default!;
        public string City { get; set; } = default!;
        public string State { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string PostalCode { get; set; } = default!;

        public IList<DoctorDetailLanguageViewModel> DoctorLanguages { get; set; } = new List<DoctorDetailLanguageViewModel>();
        public IList<DoctorDetailEducationBackgroundViewModel> DoctorEducationBackgrounds { get; set; } = new List<DoctorDetailEducationBackgroundViewModel>();
        public IList<DoctorDetailExperienceViewModel> Experiences { get; set; } = new List<DoctorDetailExperienceViewModel>();
        public IList<DoctorDetailSpecialtyViewModel> DoctorSpecialties { get; set; } = new List<DoctorDetailSpecialtyViewModel>();
    }

    public class DoctorDetailLanguageViewModel
    {
        public int LanguageId { get; set; }
        public string? LanguageName { get; set; }
    }

    public class DoctorDetailEducationBackgroundViewModel
    {
        public int DoctorEducationBackgroundId { get; set; }
        public string? InstitutionName { get; set; }
        public string? Degree { get; set; }
        public string? FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class DoctorDetailExperienceViewModel
    {
        public int DoctorExperienceId { get; set; }
        public string? CompanyName { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class DoctorDetailSpecialtyViewModel
    {
        public int? DoctorSpecialtyId { get; set; } 
        public string? SpecialtyName { get; set; }
    }
}
