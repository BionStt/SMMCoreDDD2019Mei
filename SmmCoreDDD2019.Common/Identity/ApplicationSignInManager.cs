using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SmmCoreDDD2019.Common.Identity
{
    public class ApplicationSignInManager:SignInManager<ApplicationUser>
    {
        public ApplicationSignInManager(UserManager<ApplicationUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<ApplicationUser>> logger, IAuthenticationSchemeProvider schemes)
           : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
        {
        }
        public override async Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var user = await UserManager.FindByNameAsync(userName);
            if ((user.IsEnabled == false))
            {
                return await Task.FromResult<SignInResult>(SignInResult.LockedOut);
            }
            return await base.PasswordSignInAsync(userName, password, isPersistent, lockoutOnFailure);
        }
    }
}
