using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Identity.ViewModel.Account;
using SmmCoreDDD2019.Common.SyncfusionViewModels;

namespace SMMCoreDDD2019.WebAdminLte.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly AppIdentityDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserController(AppIdentityDbContext context,
                        UserManager<ApplicationUser> userManager,
                        RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult GetUser()
        {
            //List<UserProfile> Items = new List<UserProfile>();
            //Items = _context.UserProfile.ToList();
            //int Count = Items.Count();
            //return Ok(new { Items, Count });

            List<UserListViewModel> Items = new List<UserListViewModel>();
            Items = _userManager.Users.Select(u => new UserListViewModel
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
                IsEmailConfirmed = u.EmailConfirmed,
                IsPhoneNumberConfirmed = u.PhoneNumberConfirmed,
                TwoFactor = u.TwoFactorEnabled,
                IsEnabled = u.IsEnabled,
                UserName = u.UserName

            }).ToList();
            int Count = Items.Count();
            return Ok(new { Items, Count });

        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByApplicationUserId([FromRoute]string id)
        {
            //UserProfile userProfile = _context.UserProfile.SingleOrDefault(x => x.ApplicationUserId.Equals(id));
            //List<UserProfile> Items = new List<UserProfile>();
            //if (userProfile != null)
            //{
            //    Items.Add(userProfile);
            //}
            //int Count = Items.Count();
            //return Ok(new { Items, Count });
            ApplicationUser userProfile = await _userManager.FindByIdAsync(id);
            List<ApplicationUser> Items = new List<ApplicationUser>();
            if (userProfile != null)
            {
                Items.Add(userProfile);
            }
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Insert([FromBody]CrudViewModel<UserViewModel> payload)
        {
            //UserProfile register = payload.value;
            //if (register.Password.Equals(register.ConfirmPassword))
            //{
            //    ApplicationUser user = new ApplicationUser() { Email = register.Email, UserName = register.Email, EmailConfirmed = true };
            //    var result = await _userManager.CreateAsync(user, register.Password);
            //    if (result.Succeeded)
            //    {
            //        register.Password = user.PasswordHash;
            //        register.ConfirmPassword = user.PasswordHash;
            //        register.ApplicationUserId = user.Id;
            //        _context.UserProfile.Add(register);
            //        await _context.SaveChangesAsync();
            //    }

            //}
            UserViewModel register = payload.value;
            if (register.Password.Equals(register.ConfirmPassword))
            {
                ApplicationUser user = new ApplicationUser() { Email = register.Email, UserName = register.UserName, PhoneNumber = register.PhoneNumber, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    _context.UserProfile.Add(new UserProfile
                    {
                        Password = register.Password,
                        ConfirmPassword = register.ConfirmPassword,
                        ApplicationUserId = user.Id

                    });
                    await _context.SaveChangesAsync();
                }

            }
            return Ok(register);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Remove([FromBody]CrudViewModel<UserProfile> payload)
        {
            var userProfile = _context.UserProfile.SingleOrDefault(x => x.UserProfileId.Equals((int)payload.key));
            if (userProfile != null)
            {
                var user = _context.Users.Where(x => x.Id.Equals(userProfile.ApplicationUserId)).FirstOrDefault();
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    _context.Remove(userProfile);
                    await _context.SaveChangesAsync();
                }

            }

            return Ok();

        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromBody]CrudViewModel<UserViewModel> payload)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(payload.key.ToString());
            UserViewModel profile = payload.value;
            if (user != null)
            {
                user.PhoneNumber = profile.PhoneNumber;
                user.UserName = profile.UserName;
            }
            IdentityResult result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {

                _context.UserProfile.Update(new UserProfile
                {
                    Password = profile.Password,
                });

                await _context.SaveChangesAsync();
            }
            return Ok(profile);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ChangePassword([FromBody]CrudViewModel<UserViewModel> payload)
        {
            UserViewModel profile = payload.value;
            if (profile.Password.Equals(profile.ConfirmPassword))
            {
                var user = await _userManager.FindByIdAsync(profile.Id);
                var result = await _userManager.ChangePasswordAsync(user, profile.OldPassword, profile.Password);
                profile.UserName = user.UserName;
                profile.PhoneNumber = user.PhoneNumber;
            }

            //   profile = _context.UserProfile.SingleOrDefault(x => x.ApplicationUserId.Equals(profile.Id));
            return Ok(profile);
        }

        [HttpPost("[action]")]
        public IActionResult ChangeRole([FromBody]CrudViewModel<UserProfile> payload)
        {
            UserProfile profile = payload.value;
            return Ok(profile);
        }



    }
}