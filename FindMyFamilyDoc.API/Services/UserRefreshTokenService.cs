using FindMyFamilyDoc.API.Interfaces;
using FindMyFamilyDoc.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.API.Services
{

    public class UserRefreshTokenService : IUserRefreshTokenService
    {
        private readonly DatabaseContext _context;

        public UserRefreshTokenService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<string> CreateRefreshTokenAsync(string userId)
        {
            // Generate a new refresh token
            var refreshToken = Guid.NewGuid().ToString();

            // Store the refresh token in your database
            var refreshTokenEntry = new UserRefreshToken
            {
                UserId = userId,
                Token = refreshToken,
                ExpiryDate = DateTime.UtcNow.AddHours(12) 
            };

            _context.UserRefreshTokens.Add(refreshTokenEntry);
            await _context.SaveChangesAsync();

            return refreshToken;
        }

        public async Task<bool> ValidateRefreshTokenAsync(string userId, string refreshToken)
        {
            // Check if the refresh token exists and has not expired
            var tokenEntry = await _context.UserRefreshTokens.SingleOrDefaultAsync(rt => rt.UserId == userId && rt.Token == refreshToken);

            if (tokenEntry == null || tokenEntry.ExpiryDate < DateTime.UtcNow)
            {
                return false;
            }

            return true;
        }

        public async Task InvalidateRefreshTokenAsync(string userId)
        {
            // Invalidate the refresh token
            var tokenEntry = await _context.UserRefreshTokens.SingleOrDefaultAsync(rt => rt.UserId == userId);
            if (tokenEntry != null)
            {
                _context.UserRefreshTokens.Remove(tokenEntry);
                await _context.SaveChangesAsync();
            }
        }
    }
}
