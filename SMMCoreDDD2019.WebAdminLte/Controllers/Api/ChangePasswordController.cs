using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Identity.Models.ManageViewModels;
using SmmCoreDDD2019.Common.SyncfusionViewModels;

namespace SMMCoreDDD2019.WebAdminLte.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/ChangePassword")]
    public class ChangePasswordController : Controller
    {
        private readonly AppIdentityDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public ChangePasswordController(AppIdentityDbContext context,
                        UserManager<ApplicationUser> userManager,
                        RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: api/ChangePassword
        [HttpGet]
        public IActionResult GetChangePassword()
        {
            List<ApplicationUser> Items = new List<ApplicationUser>();
            Items = _context.Users.ToList();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromBody]CrudViewModel<ChangePasswordViewModel> payload)
        {
            ChangePasswordViewModel changePasswordViewModel = payload.value;
            var user = _context.Users.SingleOrDefault(x => x.Id.Equals(changePasswordViewModel.Id));

            if (user != null &&
                changePasswordViewModel.NewPassword.Equals(changePasswordViewModel.ConfirmPassword))
            {
                await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
            }

            return Ok();
        }
    }
}