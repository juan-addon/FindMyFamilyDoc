using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;

namespace FindMyFamilyDoc.Business.Helpers
{
    public static class QueryHelper
    {
        public static async Task<IQueryable<Doctor>> GetDoctorsUnderReviewQueryAsync(DatabaseContext dbContext)
        {
            var query = from d in dbContext.Doctors
                        join u in dbContext.Users on d.UserId equals u.Id
                        join ur in dbContext.UserRoles on u.Id equals ur.UserId
                        join r in dbContext.Roles on ur.RoleId equals r.Id
                        where r.Name == UserRoles.DoctorUnderReview.ToString()
                        select d;

            return await Task.FromResult(query);
        }

        public static async Task<IQueryable<Doctor>> GetRejectedDoctorsQuery(DatabaseContext dbContext)
        {
            var query = from d in dbContext.Doctors
                        join u in dbContext.Users on d.UserId equals u.Id
                        join ur in dbContext.UserRoles on u.Id equals ur.UserId
                        join r in dbContext.Roles on ur.RoleId equals r.Id
                        where r.Name == "DoctorRejected"
                        select d;

            return await Task.FromResult(query);
        }
    }
}