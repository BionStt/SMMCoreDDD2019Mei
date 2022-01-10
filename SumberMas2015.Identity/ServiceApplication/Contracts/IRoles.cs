using SumberMas2015.Identity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Identity.ServiceApplication.Contracts
{
    public interface IRoles
    {
        Task GenerateRolesFromPagesAsync();
        Task GenerateRolesFromPagesAsync2();

        Task AddToRoles(string applicationUserId);

        Task UpdateRoles(ApplicationUser appUser, ApplicationUser currentUserLogin);
    }
}
