﻿using Microsoft.AspNetCore.Authorization;

namespace FindMyFamilyDoc.Shared.Enums
{
    public enum UserRoles
    {
        Admin,
        Doctor,
        DoctorUnderReview,
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
