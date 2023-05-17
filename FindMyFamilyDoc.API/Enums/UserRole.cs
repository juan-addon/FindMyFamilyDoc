using Microsoft.AspNetCore.Authorization;

namespace FindMyFamilyDoc.API.Enums
{
    public enum UserRoles
    {
        Admin,
        Doctor,
        Patience,
        AdministractiveAssistant,
    }

    public class RoleAuthorizeAttribute : AuthorizeAttribute
    {
        public RoleAuthorizeAttribute(UserRoles role)
        {
            Roles = Enum.GetName(typeof(UserRoles), role);
        }
    }
}
