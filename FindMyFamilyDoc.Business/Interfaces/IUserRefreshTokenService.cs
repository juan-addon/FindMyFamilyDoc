
namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IUserRefreshTokenService
    {
        Task<string> CreateRefreshTokenAsync(string userId);
        Task<bool> ValidateRefreshTokenAsync(string userId, string refreshToken);
        Task InvalidateRefreshTokenAsync(string userId);
    }
}
