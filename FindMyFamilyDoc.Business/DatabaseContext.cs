using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.Business
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var roles = Enum.GetValues(typeof(UserRoles)).Cast<UserRoles>().Select(e => new IdentityRole
            {
                Name = e.ToString(),
                NormalizedName = e.ToString().ToUpper()
            }).ToArray();

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
