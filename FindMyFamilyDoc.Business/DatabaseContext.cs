﻿using FindMyFamilyDoc.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorEducationBackground> DoctorEducationBackgrounds { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
        public DbSet<DoctorExperience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<DoctorLanguage> DoctorLanguages { get; set; }
        public DbSet<DoctorStaff> DoctorStaffs { get; set; }
        public DbSet<DoctorPatientAssociation> DoctorPatientAssociations { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalHistory> PatientMedicalHistories { get; set; }
        public DbSet<DoctorAvailability> DoctorAvailabilities { get; set; }
        public DbSet<PatientAppointment> PatientAppointments { get; set; }
        public DbSet<DoctorRejection> DoctorRejections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasAlternateKey(d => d.UserId)
                .HasName("AlternateKey_DoctorUserId");

            modelBuilder.Entity<Patient>()
                .HasAlternateKey(p => p.UserId)
                .HasName("AlternateKey_PatientUserId");

            modelBuilder.Entity<DoctorPatientAssociation>()
                .HasOne(dpa => dpa.Doctor)
                .WithMany(d => d.DoctorPatientAssociations)
                .HasForeignKey(dpa => dpa.DoctorUserId)
                .HasPrincipalKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete

            modelBuilder.Entity<DoctorPatientAssociation>()
                .HasOne(dpa => dpa.Patient)
                .WithMany(p => p.DoctorPatientAssociations)
                .HasForeignKey(dpa => dpa.PatientUserId)
                .HasPrincipalKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete

            modelBuilder.Entity<PatientAppointment>()
                .HasOne(dpa => dpa.Patient)
                .WithMany(p => p.PatientAppointments)
                .HasForeignKey(dpa => dpa.PatientId)
                .HasPrincipalKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete

            modelBuilder.Entity<PatientAppointment>()
                .HasOne(dpa => dpa.Doctor)
                .WithMany(d => d.PatientAppointments)
                .HasForeignKey(dpa => dpa.DoctorId)
                .HasPrincipalKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete

            modelBuilder.Entity<MedicalHistory>()
                .HasOne(dpa => dpa.Patient)
                .WithMany(p => p.MedicalHistories)
                .HasForeignKey(dpa => dpa.PatientId)
                .HasPrincipalKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete

            modelBuilder.Entity<MedicalHistory>()
                .HasOne(dpa => dpa.Doctor)
                .WithMany(d => d.MedicalHistories)
                .HasForeignKey(dpa => dpa.DoctorId)
                .HasPrincipalKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Doctor>()
            //   .HasMany(d => d.DoctorStaffs)
            //   .WithOne(s => s.Doctor)
            //   .HasForeignKey(s => s.DoctorId)
            //   .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BaseEntity>().Property(b => b.CreatedAt).HasDefaultValueSql("GETDATE()");

            /*var roles = Enum.GetValues(typeof(UserRoles)).Cast<UserRoles>().Select(e => new IdentityRole
            {
                Name = e.ToString(),
                NormalizedName = e.ToString().ToUpper()
            }).ToArray();*/

            /*var roles = Enum.GetValues(typeof(UserRoles))
            .Cast<UserRoles>()
            .Select(e => {
                var memInfo = typeof(UserRoles).GetMember(e.ToString());
                var descriptionAttribute = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                var description = ((DescriptionAttribute)descriptionAttribute[0]).Description;

                return new IdentityRole
                {
                    Name = e.ToString(),
                    NormalizedName = description
                };
            })
            .ToArray();*/

            //modelBuilder.Entity<IdentityRole>().HasData(roles);
            //ModelBuilderStateDataSeeder.Seed(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
