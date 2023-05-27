namespace FindMyFamilyDoc.Shared.Models
{
    public class State: BaseEntity
    {
        public string Name { get; set; } = default!;
        // This will automatically include all cities in a given state
        public virtual ICollection<City> Cities { get; set; }  = new List<City>();
    }
}
