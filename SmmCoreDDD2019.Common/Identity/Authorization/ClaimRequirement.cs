using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Identity.Authorization
{
    public class ClaimRequirement : IAuthorizationRequirement
    {
        public ClaimRequirement(string claimName, string claimValue)
        {
            ClaimName = claimName;
            ClaimValue = claimValue;
        }

        public string ClaimName { get; set; }
        public string ClaimValue { get; set; }
    }
}
