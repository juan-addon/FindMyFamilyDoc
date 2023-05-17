using FindMyFamilyDoc.API.Enums;
using FindMyFamilyDoc.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.API
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }


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
