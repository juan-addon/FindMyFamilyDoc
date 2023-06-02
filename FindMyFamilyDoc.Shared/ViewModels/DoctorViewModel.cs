using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class DoctorViewModel
    {
        [Required]
        public string Title { get; set; } = default!;
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public string Phone { get; set; } = default!;
        [Required]
        public string ContactInformation { get; set; } = default!;
        [Required]
        public string Availability { get; set; } = default!;
        [Required]
        public int WaitingTime { get; set; }
        [Required]
        public decimal Fees { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public bool IsAcceptingNewPatients { get; set; } = false;
        public string UserId { get; set; } = default!;
        [Required]
        public int CityId { get; set; }
        [Required]
        public string StreetNumber { get; set; } = default!;
        [Required]
        public string PostalCode { get; set; } = default!;
        public IList<DoctorLanguageViewModel> DoctorLanguages { get; set; } = new List<DoctorLanguageViewModel>();
        public IList<DoctorEducationBackgroundViewModel> DoctorEducationBackgrounds { get; set; } = new List<DoctorEducationBackgroundViewModel>();
        public IList<DoctorExperienceViewModel> Experiences { get; set; } = new List<DoctorExperienceViewModel>();
        public IList<DoctorSpecialtyViewModel> DoctorSpecialties { get; set; } = new List<DoctorSpecialtyViewModel>();
    }

    public class DoctorLanguageViewModel
    {
        public int LanguageId { get; set; }
    }

    public class DoctorEducationBackgroundViewModel
    {
        public string InstitutionName { get; set; } = default!;
        [Required]
        public string Degree { get; set; } = default!;
        [Required]
        public string FieldOfStudy { get; set; } = default!;
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class DoctorExperienceViewModel
    {
        [Required]
        public string CompanyName { get; set; } = default!;
        [Required]
        public string Description { get; set; } = default!;
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class DoctorSpecialtyViewModel
    {
        public int SpecialtyId { get; set; }
    }
}