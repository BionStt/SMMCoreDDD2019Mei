using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmmCoreDDD2019.Common.Identity;

namespace SMMCoreDDD2019.WebUI.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRoleController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


       // [Authorize(Roles = SmmCoreDDD2019.Common.Pages.MainMenu.User.RoleName)]
        public IActionResult Index()
        {
            return View();
        }

       // [Authorize(Roles = SmmCoreDDD2019.Common.Pages.MainMenu.ChangePassword.RoleName)]
        public IActionResult ChangePassword()
        {
            return View();
        }

      //  [Authorize(Roles = SmmCoreDDD2019.Common.Pages.MainMenu.Role.RoleName)]
        public IActionResult Role()
        {
            return View();
        }

       // [Authorize(Roles = SmmCoreDDD2019.Common.Pages.MainMenu.ChangeRole.RoleName)]
        public IActionResult ChangeRole()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> UserProfile()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            return View(user);
        }
    }
}