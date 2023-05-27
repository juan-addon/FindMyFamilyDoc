namespace FindMyFamilyDoc.Shared.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = default!;
        public int StateId { get; set; } // Foreign key
        public State State { get; set; } = default!;
    }
}
