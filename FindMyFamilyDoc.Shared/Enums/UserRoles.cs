using Microsoft.AspNetCore.Authorization;
using System.ComponentModel;

namespace FindMyFamilyDoc.Shared.Enums
{
    public enum UserRoles
    {
        [Description("Administrator")]
        Admin,

        [Description("Medical Practitioner")]
        Doctor,

        [Description("Doctor Under Review")]
        DoctorUnderReview,

        [Description("Patient")]
        Patient,

        [Description("Administrative Assistant")]
        AdministrativeAssistant,

        [Description("Doctor Rejected")]
        DoctorRejected,
    }

    /*public class RoleAuthorizeAttribute : AuthorizeAttribute
    {
        public RoleAuthorizeAttribute(UserRoles role)
        {
            Roles = Enum.GetName(typeof(UserRoles), role);
        }
    }*/

    public class RoleAuthorizeAttribute : AuthorizeAttribute
    {
        public RoleAuthorizeAttribute(params UserRoles[] roles)
        {
            Roles = string.Join(",", roles.Select(role => Enum.GetName(typeof(UserRoles), role)));
        }
    }
}
