using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Pages;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRoleController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


        [Authorize(Roles = MainMenu.User.RoleName)]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = MainMenu.ChangePassword.RoleName)]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Authorize(Roles = MainMenu.Role.RoleName)]
        public IActionResult Role()
        {
            return View();
        }

        [Authorize(Roles = MainMenu.ChangeRole.RoleName)]
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
