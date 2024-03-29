﻿using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.ViewModels
{
    public class DoctorViewModel: BaseUserViewModel
    {
        [Required]
        public string UserId { get; set; } = default!;

        [Required]
        public string Title { get; set; } = default!;
        [Required]
        public string WaitingTime { get; set; } = default!;
        [Required]
        public decimal Fees { get; set; }
        public string? ProfilePicture { get; set; }
        public bool IsAcceptingNewPatients { get; set; } = false;
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

    public class DoctorsUnderReviewViewModel
    {
        public int DoctorId { get; set; }
        public string DoctorUserId { get; set; } = default!;
        public string DoctorName { get; set; } = default!;
        public bool IsAcceptingNewPatients { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Title { get; set; } = default!;
        public decimal Fees { get; set; } = default!;
        public string State { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
    }

    public class DoctorRejectionViewModel
    {
        [Required]
        public string UserId { get; set; } = default!;

        [Required]
        public string RejectionReason { get; set; } = default!;
    }
}