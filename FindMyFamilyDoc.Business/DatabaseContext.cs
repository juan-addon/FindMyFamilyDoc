using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FindMyFamilyDoc.Business.Helpers;

namespace FindMyFamilyDoc.Business
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<DoctorEducationBackground> DoctorEducationBackgrounds { get; set; }
		public DbSet<Specialty> Specialties { get; set; }
		public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
		public DbSet<DoctorExperience> Experiences { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<DoctorLanguage> DoctorLanguages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var roles = Enum.GetValues(typeof(UserRoles)).Cast<UserRoles>().Select(e => new IdentityRole
            {
                Name = e.ToString(),
                NormalizedName = e.ToString().ToUpper()
            }).ToArray();

            modelBuilder.Entity<IdentityRole>().HasData(roles);
            ModelBuilderStateDataSeeder.Seed(modelBuilder);
        }
    }
}
