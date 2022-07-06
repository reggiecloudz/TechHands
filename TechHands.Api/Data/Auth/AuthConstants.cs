using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechHands.Api.Data.Auth
{
    public static class AuthConstants
    {
        public static class Roles
        {
            public const string Administrator = "Administrator";
            public const string Technician = "Technician";
            public const string Client = "Client";
        }

        public static class Policies
        {
            public const string RequireAdmin = "RequireAdmin";
            public const string RequireTechnician = "RequireTechnician";
        }
    }
}