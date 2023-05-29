﻿using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Doctor : BaseEntity
    {

		[Required]
		public string Title { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Phone { get; set; }

		[Required]
		public string ContactInformation { get; set; }

		[Required]
		public string Availability { get; set; }

		[Required]
		public int WaitingTime { get; set; }

		public float Rating { get; set; }

		[Required]
		public decimal Fees { get; set; }

		public byte[] ProfilePicture { get; set; }

		[Required]
		public bool IsAcceptingNewPatients { get; set; }

		public ICollection<DoctorLanguage> DoctorLanguages { get; set; } = new List<DoctorLanguage>();

		public ICollection<DoctorEducationBackground> DoctorEducationBackgrounds { get; set; } = new List<DoctorEducationBackground>();

		public ICollection<DoctorExperience> Experiences { get; set; } = new List<DoctorExperience>();

		public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; } = new List<DoctorSpecialty>();
	}
}
