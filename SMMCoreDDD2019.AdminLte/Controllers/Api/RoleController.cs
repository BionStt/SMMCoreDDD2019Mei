using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using SumberMas2015.Identity.Domain;
using SumberMas2015.Identity.Infrastructure.Context;
using SumberMas2015.Identity.ServiceApplication.Contracts;
using SumberMas2015.Identity.ServiceApplication.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Role")]
    public class RoleController : Controller
    {
        private readonly AppIdentityDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRoles _roles;

        public RoleController(AppIdentityDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IRoles roles)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _roles = roles;
        }

        // GET: api/Role
        [HttpGet]
        public async Task<IActionResult> GetRole()
        {
            await _roles.GenerateRolesFromPagesAsync();

            List<IdentityRole> Items = new List<IdentityRole>();
            Items = _roleManager.Roles.ToList();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        // GET: api/Role
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetRoleByApplicationUserId([FromRoute] string id)
        {
            await _roles.GenerateRolesFromPagesAsync();
            var user = await _userManager.FindByIdAsync(id);
            var roles = _roleManager.Roles.ToList();
            List<UserRoleViewModel> Items = new List<UserRoleViewModel>();
            int count = 1;
            foreach (var item in roles)
            {
                bool isInRole = (await _userManager.IsInRoleAsync(user, item.Name)) ? true : false;
                Items.Add(new UserRoleViewModel { CounterId = count, ApplicationUserId = id, RoleName = item.Name, IsHaveAccess = isInRole });
                count++;
            }

            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateUserRole([FromBody] UserRoleViewModel userRoleViewModel)
        {
           // UserRoleViewModel userRole = payload.value;
            if (userRoleViewModel != null)
            {
                var user = await _userManager.FindByIdAsync(userRoleViewModel.ApplicationUserId);
                if (user != null)
                {
                    if (userRoleViewModel.IsHaveAccess)
                    {
                        await _userManager.AddToRoleAsync(user, userRoleViewModel.RoleName);
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(user, userRoleViewModel.RoleName);
                    }
                }
            }
            return Ok(userRoleViewModel);
        }


    }
}
