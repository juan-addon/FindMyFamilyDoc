using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Shared.Models
{
    public class State: BaseEntity
    {
        [StringLength(200)]
        public string Name { get; set; } = default!;
        public virtual ICollection<City> Cities { get; set; }  = new List<City>();
    }
}