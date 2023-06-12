using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class PersonBaseEntity : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = default!;

        [StringLength(50)]
        public string MiddleName { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = default!;
    }
}