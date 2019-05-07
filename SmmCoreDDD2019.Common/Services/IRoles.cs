using SmmCoreDDD2019.Common.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Services
{
    public interface IRoles
    {
        Task GenerateRolesFromPagesAsync();
        Task GenerateRolesFromPagesAsync2();

        Task AddToRoles(string applicationUserId);

        Task UpdateRoles(ApplicationUser appUser, ApplicationUser currentUserLogin);
    }
}
