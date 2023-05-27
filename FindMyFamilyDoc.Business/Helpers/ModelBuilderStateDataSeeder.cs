using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.Business.Helpers
{
    public static class ModelBuilderStateDataSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>().HasData(
                new State
                {
                    Id = 1,
                    Name = "Alberta",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now
                },
                new State
                {
                    Id = 2,
                    Name = "British Columbia",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 3,
                    Name = "Manitoba",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 4,
                    Name = "New Brunswick",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 5,
                    Name = "Newfoundland and Labrador",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 6,
                    Name = "Nova Scotia",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 7,
                    Name = "Ontario",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 8,
                    Name = "Prince Edward Island",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 9,
                    Name = "Quebec",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 10,
                    Name = "Saskatchewan",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 11,
                    Name = "Northwest Territories",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 12,
                    Name = "Nunavut",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                },
                new State
                {
                    Id = 13,
                    Name = "Yukon",
                    CreatedBy = "System",
                    CreatedAt = DateTime.Now,
                }
            );

            //Ontario

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Toronto", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 2, Name = "Ottawa", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 3, Name = "Mississauga", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 4, Name = "Brampton", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 5, Name = "Hamilton", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 6, Name = "London", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 7, Name = "Markham", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 8, Name = "Vaughan", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 9, Name = "Kitchener", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 10, Name = "Windsor", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 11, Name = "Richmond Hill", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 12, Name = "Oakville", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 13, Name = "Burlington", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 14, Name = "Greater Sudbury", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 15, Name = "Waterloo", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 16, Name = "Oshawa", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 17, Name = "Barrie", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 18, Name = "Kingston", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 19, Name = "Guelph", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 20, Name = "Thunder Bay", StateId = 7, CreatedBy = "System", CreatedAt = DateTime.Now }
            );

            // Alberta

            modelBuilder.Entity<City>().HasData(
                new City { Id = 21, Name = "Calgary", StateId = 1, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 22, Name = "Edmonton", StateId = 1, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 23, Name = "Red Deer", StateId = 1, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 24, Name = "Lethbridge", StateId = 1, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 25, Name = "St. Albert", StateId = 1, CreatedBy = "System", CreatedAt = DateTime.Now }
            );

            // Quebec Cities
            modelBuilder.Entity<City>().HasData(
                new City { Id = 26, Name = "Montreal", StateId = 9, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 27, Name = "Quebec City", StateId = 9, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 28, Name = "Laval", StateId = 9, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 29, Name = "Gatineau", StateId = 9, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 30, Name = "Longueuil", StateId = 9, CreatedBy = "System", CreatedAt = DateTime.Now }
            );

            // New Brunswick Cities
            modelBuilder.Entity<City>().HasData(
                new City { Id = 31, Name = "Moncton", StateId = 4, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 32, Name = "Saint John", StateId = 4, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 33, Name = "Fredericton", StateId = 4, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 34, Name = "Dieppe", StateId = 4, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 35, Name = "Riverview", StateId = 4, CreatedBy = "System", CreatedAt = DateTime.Now }
            );

            // Manitoba
            modelBuilder.Entity<City>().HasData(
                new City { Id = 36, Name = "Winnipeg", StateId = 3, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 37, Name = "Brandon", StateId = 3, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 38, Name = "Steinbach", StateId = 3, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 39, Name = "Thompson", StateId = 3, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 40, Name = "Portage la Prairie", StateId = 3, CreatedBy = "System", CreatedAt = DateTime.Now }
            );

            // Newfoundland and Labrador
            modelBuilder.Entity<City>().HasData(
                new City { Id = 41, Name = "St. John's", StateId = 5, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 42, Name = "Mount Pearl", StateId = 5, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 43, Name = "Conception Bay South", StateId = 5, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 44, Name = "Paradise", StateId = 5, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 45, Name = "Corner Brook", StateId = 5, CreatedBy = "System", CreatedAt = DateTime.Now }
            );

            // Nova Scotia
            modelBuilder.Entity<City>().HasData(
                new City { Id = 46, Name = "Halifax", StateId = 6, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 47, Name = "Sydney", StateId = 6, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 48, Name = "Truro", StateId = 6, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 49, Name = "New Glasgow", StateId = 6, CreatedBy = "System", CreatedAt = DateTime.Now },
                new City { Id = 50, Name = "Glace Bay", StateId = 6, CreatedBy = "System", CreatedAt = DateTime.Now }
            );

            // Seeding Specialty

            modelBuilder.Entity<Specialty>().HasData(
                new Specialty { Id = 1, Name = "Allergists/Immunologists", Status = SpecialtyStatus.Active, CreatedBy = "System", CreatedAt = DateTime.Now },
                new Specialty { Id = 2, Name = "Anesthesiologists", Status = SpecialtyStatus.Active, CreatedBy = "System", CreatedAt = DateTime.Now },
                new Specialty { Id = 3, Name = "Cardiologists", Status = SpecialtyStatus.Active, CreatedBy = "System", CreatedAt = DateTime.Now },
                new Specialty { Id = 4, Name = "Family and General Practitioners", Status = SpecialtyStatus.Active, CreatedBy = "System", CreatedAt = DateTime.Now },
                new Specialty { Id = 5, Name = "Neurologists", Status = SpecialtyStatus.Active, CreatedBy = "System", CreatedAt = DateTime.Now }
            );
        }
    }

}
