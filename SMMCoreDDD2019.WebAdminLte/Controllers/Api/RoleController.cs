using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Identity.Models.AccountViewModels;
using SmmCoreDDD2019.Common.Services;
using SmmCoreDDD2019.Common.SyncfusionViewModels;
namespace SMMCoreDDD2019.WebAdminLte.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Role")]
    public class RoleController : Controller
    {
        private readonly AppIdentityDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IRoles _roles;

        public RoleController(AppIdentityDbContext context,
                        UserManager<ApplicationUser> userManager,
                        RoleManager<ApplicationRole> roleManager,
                        IRoles roles)
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

            List<ApplicationRole> Items = new List<ApplicationRole>();
            Items = _roleManager.Roles.ToList();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        // GET: api/Role
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetRoleByApplicationUserId([FromRoute]string id)
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
        public async Task<IActionResult> UpdateUserRole([FromBody]CrudViewModel<UserRoleViewModel> payload)
        {
            UserRoleViewModel userRole = payload.value;
            if (userRole != null)
            {
                var user = await _userManager.FindByIdAsync(userRole.ApplicationUserId);
                if (user != null)
                {
                    if (userRole.IsHaveAccess)
                    {
                        await _userManager.AddToRoleAsync(user, userRole.RoleName);
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(user, userRole.RoleName);
                    }
                }
            }
            return Ok(userRole);
        }
    }
}