using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class DoctorDetailViewModel : BaseUserViewModel
    {
        [Required]
        public string UserId { get; set; } = default!;
        public int DoctorId { get; set; } 
        public string Title { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string WaitingTime { get; set; } = default!;
        public decimal Fees { get; set; }
        public string ProfilePicture { get; set; } = default!;
        public bool IsAcceptingNewPatients { get; set; } = false;
        public string CityName { get; set; } = default!;
        public int StateId { get; set; } = default!;
        public string State { get; set; } = default!;
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
        public int? SpecialtyId { get; set; } 
        public string? SpecialtyName { get; set; }
    }

    public class DoctorUserIdViewModel
    {
        [Required]
        public string UserId { get; set; } = default!;
    }
}
