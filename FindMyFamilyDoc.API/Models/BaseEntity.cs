using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.API.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? CreatedBy { get; set; }
    }
}
