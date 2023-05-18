namespace FindMyFamilyDoc.Shared.Models
{
    public class UserRefreshToken
    {
        public int Id { get; set; } = default!;
        public string Token { get; set; } = default!;
        public string UserId { get; set; } = default!;
        public DateTime ExpiryDate { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}
