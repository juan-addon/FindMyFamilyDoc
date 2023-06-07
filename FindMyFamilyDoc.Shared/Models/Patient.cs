using FindMyFamilyDoc.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class Patient : PersonBaseEntity
    {
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = default!;
        public Gender Gender { get; set; } = default!;
        public string EmergencyContact { get; set; } = default!;
        public string CurrentMedications { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; } 
        public string Occupation { get; set; } = default!;

        [Required]
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;

        // 1:N relationship to PatientMedicalHistory
        public ICollection<MedicalHistory> PatientMedicalHistory { get; set; } = new List<MedicalHistory>();

        // 1:N relationship to Doctor through PatientDoctor
        public ICollection<DoctorPatient> Doctors { get; set; } = new List<DoctorPatient>();
    }
}

/*
We can create this trigger to ensure our database integrity or we can delegate this logic to the application

CREATE TRIGGER [CheckActiveDoctor] ON [PatientDoctors]
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM [PatientDoctors]
        WHERE [PatientId] = INSERTED.[PatientId]
        GROUP BY [PatientId]
        HAVING SUM(CASE WHEN [IsActive] = 1 THEN 1 ELSE 0 END) > 1
    )
    BEGIN
        RAISERROR ('A patient can only have one active doctor', 16, 1);
        ROLLBACK TRANSACTION;
    END
END

 */
