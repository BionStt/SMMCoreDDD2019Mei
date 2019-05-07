using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Infrastructure.Services;

using SMMCoreDDD2019.WebUI.Extensions;
using SmmCoreDDD2019.Common.Identity.ViewModel.Account;
using SmmCoreDDD2019.Common.Identity.ViewModel.Manage;
using SmmCoreDDD2019.Common.Identity.Models.AccountViewModels;

namespace SMMCoreDDD2019.WebUI.Controllers
{
   // [Authorize(Roles = "ADMINISTRATOR")]
    public class UserController:Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        private readonly ISmsSender _smsSender;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly UrlEncoder _urlEncoder;

        private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
        private const string RecoveryCodesKey = nameof(RecoveryCodesKey);

        public UserController(
          UserManager<ApplicationUser> userManager,
          SignInManager<ApplicationUser> signInManager,
          IEmailSender emailSender,
          ISmsSender smsSender,
          ILogger<ManageController> logger,
          UrlEncoder urlEncoder,
          RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = logger;
            _urlEncoder = urlEncoder;
            this.roleManager = roleManager;
        }


        [TempData]
        public string StatusMessage { get; set; }
        [HttpGet]
        public IActionResult Index2()
        {
            List<UserListViewModel> model = new List<UserListViewModel>();
            model = _userManager.Users.Select(u => new UserListViewModel
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
                IsEmailConfirmed = u.EmailConfirmed,
                IsPhoneNumberConfirmed = u.PhoneNumberConfirmed,
                TwoFactor = u.TwoFactorEnabled,
                IsEnabled = u.IsEnabled,
                UserName = u.UserName,
                ProfilePictureUrl = u.profilePictureUrl

            }).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<UserListViewModel> model = new List<UserListViewModel>();
            model = _userManager.Users.Select(u => new UserListViewModel
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
            return View(model);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            UserViewModel model = new UserViewModel();
            model.ApplicationRoles = roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();
            return PartialView("_AddUser", model);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Name = model.Name,
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber
                };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    ApplicationRole applicationRole = await roleManager.FindByIdAsync(model.ApplicationRoleId);
                    if (applicationRole != null)
                    {
                        IdentityResult roleResult = await _userManager.AddToRoleAsync(user, applicationRole.Name);
                        if (roleResult.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        System.Diagnostics.Debug.WriteLine("Error code [" + error.Code + "], Error description [" + error.Description + "]");
                    }
                }

            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddUser2()
        {
            UserViewModel model = new UserViewModel();
            model.ApplicationRoles = roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();
            // return PartialView("_AddUser", model);
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AddUser2(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Name = model.Name,
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    IsEnabled = true
                };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    ApplicationRole applicationRole = await roleManager.FindByIdAsync(model.ApplicationRoleId);
                    if (applicationRole != null)
                    {
                        IdentityResult roleResult = await _userManager.AddToRoleAsync(user, applicationRole.Name);
                        if (roleResult.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        System.Diagnostics.Debug.WriteLine("Error code [" + error.Code + "], Error description [" + error.Description + "]");
                    }
                }

            }
            return View(model);
        }



        [HttpGet]
        public async Task<IActionResult> EditUserPWD(string id)
        {
            EditUserPWDViewModel model = new EditUserPWDViewModel();
            model.ApplicationRoles = roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();

            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    model.Name = user.Name;
                    model.Email = user.Email;
                    model.PhoneNumber = user.PhoneNumber;
                    //  model.Password = user.PasswordHash;

                    model.ApplicationRoleId = roleManager.Roles.Single(r => r.Name == _userManager.GetRolesAsync(user).Result.Single()).Id;
                }
            }
            return PartialView("_EditUserPWD", model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUserPWD(string id, EditUserPWDViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.Name = model.Name;
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    //  user.PasswordHash = model.Password;

                    //IdentityResult result = await userManager.ChangePasswordAsync(user,model.CurrentPassword,model.Password);
                    //if (result.Succeeded)
                    //{
                    //    return RedirectToAction("Index");
                    //}
                    IdentityResult resultDeletePwd = await _userManager.RemovePasswordAsync(user);
                    if (resultDeletePwd.Succeeded)
                    {
                        IdentityResult result = await _userManager.AddPasswordAsync(user, model.Password);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                    }

                    //string existingRole = userManager.GetRolesAsync(user).Result.Single();
                    //string existingRoleId = roleManager.Roles.Single(r => r.Name == existingRole).Id;
                    //IdentityResult result = await userManager.UpdateAsync(user);
                    //if (result.Succeeded)
                    //{
                    //    if (existingRoleId != model.ApplicationRoleId)
                    //    {
                    //        IdentityResult roleResult = await userManager.RemoveFromRoleAsync(user, existingRole);
                    //        if (roleResult.Succeeded)
                    //        {
                    //            ApplicationRole applicationRole = await roleManager.FindByIdAsync(model.ApplicationRoleId);
                    //            if (applicationRole != null)
                    //            {
                    //                IdentityResult newRoleResult = await userManager.AddToRoleAsync(user, applicationRole.Name);
                    //                if (newRoleResult.Succeeded)
                    //                {
                    //                    return RedirectToAction("Index");
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                }
            }
            //  return PartialView("_EditUser", model);
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            EditUserViewModel model = new EditUserViewModel();
            model.ApplicationRoles = roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();

            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    model.Name = user.Name;
                    model.Email = user.Email;
                    model.PhoneNumber = user.PhoneNumber;
                    model.ApplicationRoleId = roleManager.Roles.Single(r => r.Name == _userManager.GetRolesAsync(user).Result.Single()).Id;
                }
            }
            return PartialView("_EditUser", model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(string id, EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.Name = model.Name;
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    string existingRole = _userManager.GetRolesAsync(user).Result.Single();
                    string existingRoleId = roleManager.Roles.Single(r => r.Name == existingRole).Id;
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        if (existingRoleId != model.ApplicationRoleId)
                        {
                            IdentityResult roleResult = await _userManager.RemoveFromRoleAsync(user, existingRole);
                            if (roleResult.Succeeded)
                            {
                                ApplicationRole applicationRole = await roleManager.FindByIdAsync(model.ApplicationRoleId);
                                if (applicationRole != null)
                                {
                                    IdentityResult newRoleResult = await _userManager.AddToRoleAsync(user, applicationRole.Name);
                                    if (newRoleResult.Succeeded)
                                    {
                                        return RedirectToAction("Index");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //  return PartialView("_EditUser", model);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
          List<UserRoleViewModel> Items = new List<UserRoleViewModel>();
            int count = 1;
            var roles = roleManager.Roles.ToList();

            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    ViewBag.Name = user.Name;
                    ViewBag.Email = user.Email;
                    ViewBag.PhoneNumber = user.PhoneNumber;
                    ViewBag.UserName = user.UserName;
                    ViewBag.ApplicationUSerID = user.Id;
                }
                foreach (var item in roles)
                {
                    bool isInRole = (await _userManager.IsInRoleAsync(user, item.Name)) ? true : false;
                    Items.Add(new UserRoleViewModel { CounterId = count, ApplicationUserId = id, RoleName = item.Name, IsHaveAccess = isInRole });
                    count++;
                }
                ViewBag.ItemTest1 = Items;
                int Count = Items.Count();
            }

            return View(Items);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(string id, UserRoleViewModel model)
        {
                     
                UserRoleViewModel userRole = model;
                if (userRole != null)
                {
                var user = await _userManager.FindByIdAsync(model.ApplicationUserId);
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
                             
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> EditUser2(string id)
        {
            EditUserViewModel model = new EditUserViewModel();
            List<UserRoleViewModel> Items = new List<UserRoleViewModel>();
            int count = 1;
            var roles = roleManager.Roles.ToList();
            
            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    model.Name = user.Name;
                    model.Email = user.Email;
                    model.PhoneNumber = user.PhoneNumber;
                    model.UserName = user.UserName;
                    }
                foreach (var item in roles)
                {
                    bool isInRole = (await _userManager.IsInRoleAsync(user, item.Name)) ? true : false;
                    Items.Add(new UserRoleViewModel { CounterId = count, ApplicationUserId = id, RoleName = item.Name, IsHaveAccess = isInRole });
                    count++;
                }
                ViewBag.ItemTest1 = Items;
                int Count = Items.Count();
            }
           
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser2(string id, EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.Name = model.Name;
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    user.UserName = model.UserName;

                    string existingRole = _userManager.GetRolesAsync(user).Result.Single();
                    string existingRoleId = roleManager.Roles.Single(r => r.Name == existingRole).Id;
                    IdentityResult result = await _userManager.UpdateAsync(user);
                   // return RedirectToAction(nameof(Index));
                    //if (result.Succeeded)
                    //{
                    //    if (existingRoleId != model.ApplicationRoleId)
                    //    {
                    //        IdentityResult roleResult = await _userManager.RemoveFromRoleAsync(user, existingRole);
                    //        if (roleResult.Succeeded)
                    //        {
                    //            ApplicationRole applicationRole = await roleManager.FindByIdAsync(model.ApplicationRoleId);
                    //            if (applicationRole != null)
                    //            {
                    //                IdentityResult newRoleResult = await _userManager.AddToRoleAsync(user, applicationRole.Name);
                    //                if (newRoleResult.Succeeded)
                    //                {
                    //                    // return RedirectToAction("Index");
                    //                    return RedirectToAction(nameof(Index));
                    //                }
                    //            }
                    //        }
                    //    }
                    //    else
                    //    { return RedirectToAction(nameof(Index)); }
                    //}
                }
            }
            //  return PartialView("_EditUser", model);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditUserPWD2(string id)
        {
            EditUserPWDViewModel model = new EditUserPWDViewModel();
            model.ApplicationRoles = roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();

            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    model.Name = user.Name;
                    model.Email = user.Email;
                    model.PhoneNumber = user.PhoneNumber;
                    //  model.Password = user.PasswordHash;

                   // model.ApplicationRoleId = roleManager.Roles.Single(r => r.Name == _userManager.GetRolesAsync(user).Result.Single()).Id;
                }
            }
            //  return PartialView("_EditUserPWD", model);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUserPWD2(string id, EditUserPWDViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.Name = model.Name;
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    //  user.PasswordHash = model.Password;

                    //IdentityResult result = await userManager.ChangePasswordAsync(user,model.CurrentPassword,model.Password);
                    //if (result.Succeeded)
                    //{
                    //    return RedirectToAction("Index");
                    //}
                    IdentityResult resultDeletePwd = await _userManager.RemovePasswordAsync(user);
                    if (resultDeletePwd.Succeeded)
                    {
                        IdentityResult result = await _userManager.AddPasswordAsync(user, model.Password);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                    }

                    //string existingRole = userManager.GetRolesAsync(user).Result.Single();
                    //string existingRoleId = roleManager.Roles.Single(r => r.Name == existingRole).Id;
                    //IdentityResult result = await userManager.UpdateAsync(user);
                    //if (result.Succeeded)
                    //{
                    //    if (existingRoleId != model.ApplicationRoleId)
                    //    {
                    //        IdentityResult roleResult = await userManager.RemoveFromRoleAsync(user, existingRole);
                    //        if (roleResult.Succeeded)
                    //        {
                    //            ApplicationRole applicationRole = await roleManager.FindByIdAsync(model.ApplicationRoleId);
                    //            if (applicationRole != null)
                    //            {
                    //                IdentityResult newRoleResult = await userManager.AddToRoleAsync(user, applicationRole.Name);
                    //                if (newRoleResult.Succeeded)
                    //                {
                    //                    return RedirectToAction("Index");
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                }
            }
            //  return PartialView("_EditUser", model);
            return View(model);
        }



        [HttpGet]

        public async Task<IActionResult> DeleteUser(string id)
        {
            string name = string.Empty;
            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser applicationUser = await _userManager.FindByIdAsync(id);
                if (applicationUser != null)
                {
                    name = applicationUser.Name;
                }
            }
            return PartialView("_DeleteUser", name);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id, IFormCollection form)
        // public async Task<IActionResult> DeleteUser(string id, FormCollection form)
        {
            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser applicationUser = await _userManager.FindByIdAsync(id);
                if (applicationUser != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync(applicationUser);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> DeleteUser2(string id)
        {
            string name = string.Empty;
            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser applicationUser = await _userManager.FindByIdAsync(id);
                if (applicationUser != null)
                {
                    name = applicationUser.Name;
                }
            }
            //  return PartialView("_DeleteUser", name);
            return View("DeleteUser2", name);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser2(string id, IFormCollection form)
        // public async Task<IActionResult> DeleteUser(string id, FormCollection form)
        {
            if (!String.IsNullOrEmpty(id))
            {
                ApplicationUser applicationUser = await _userManager.FindByIdAsync(id);
                if (applicationUser != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync(applicationUser);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }

        //
        // GET: /Manage/VerifyPhoneNumber
        [HttpGet]
        public async Task<IActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Error");
            }
            // var code = await _userManager.GenerateChangePhoneNumberTokenAsync(user, phoneNumber);
            // Send an SMS to verify the phone number
            //    return phoneNumber == null ? View("Error") : View(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });
            return phoneNumber == null ? View("Error") : View(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });
        }

        //
        // POST: /Manage/VerifyPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyPhoneNumber(VerifyPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var result = await _userManager.ChangePhoneNumberAsync(user, model.PhoneNumber, model.Code);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    //   return RedirectToAction(nameof(Index), new { Message = ManageMessageId.AddPhoneSuccess });
                    StatusMessage = "Verification SMS Complete";
                    return RedirectToAction(nameof(Index));
                }
            }
            // If we got this far, something failed, redisplay the form
            ModelState.AddModelError(string.Empty, "Failed to verify phone number");
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendVerificationEmail(UserListViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
            var email = user.Email;
            await _emailSender.SendEmailConfirmationAsync(email, callbackUrl);

            StatusMessage = "Verification email sent. Please check your email.";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendVerificationSMS(UserListViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var PhoneNumber1 = user.PhoneNumber;
            var code = await _userManager.GenerateChangePhoneNumberTokenAsync(user, PhoneNumber1);
            await _smsSender.SendSmsAsync(model.PhoneNumber, "Your security code is: " + code);
            StatusMessage = "Verification SMS sent. Please check your SMS.";
            return RedirectToAction(nameof(VerifyPhoneNumber), new { PhoneNumber = PhoneNumber1 });
        }

        //
        // POST: /Manage/EnableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnableTwoFactorAuthentication()
        {

            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                await _userManager.SetTwoFactorEnabledAsync(user, true);
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation(1, "User enabled two-factor authentication.");
            }
            return RedirectToAction(nameof(Index), "User");
        }

        //
        // POST: /Manage/DisableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DisableTwoFactorAuthentication()
        {

            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                await _userManager.SetTwoFactorEnabledAsync(user, false);
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation(2, "User disabled two-factor authentication.");
            }
            return RedirectToAction(nameof(Index), "User");
        }

        //
        // POST: /Manage/EnableAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnableAccount(string UserName)
        {
            if (UserName == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(UserName);
            // var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                if (user.IsEnabled == false)
                {
                    user.IsEnabled = true;
                    await _userManager.UpdateAsync(user);
                }
                _logger.LogInformation(1, "Administrator enabled Account.");
            }
            return RedirectToAction(nameof(Index), "User");
        }

        //
        // POST: /Manage/DisableAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DisableAccount(string UserName)
        {
            if (UserName == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(UserName);
            // var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                if (user.IsEnabled == true)
                {
                    user.IsEnabled = false;
                    await _userManager.UpdateAsync(user);
                }
                _logger.LogInformation(1, "Administrator Disabled Account.");
            }
            return RedirectToAction(nameof(Index), "User");
        }

        //
        // POST: /Manage/EnableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnableTwoFactorAuthentication2(string UserName)
        {
            if (UserName == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(UserName);
            if (user != null)
            {
                await _userManager.SetTwoFactorEnabledAsync(user, true);
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation(1, "User enabled two-factor authentication.");
            }
            return RedirectToAction(nameof(Index), "User");
        }

        //
        // POST: /Manage/DisableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DisableTwoFactorAuthentication2(string UserName)
        {
            if (UserName == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(UserName);
            if (user != null)
            {
                await _userManager.SetTwoFactorEnabledAsync(user, false);
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation(2, "User disabled two-factor authentication.");
            }
            return RedirectToAction(nameof(Index), "User");
        }

        //
        // POST: /Manage/EnableAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnableAccount2()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                if (user.IsEnabled == false)
                {
                    user.IsEnabled = true;
                    await _userManager.UpdateAsync(user);
                }
                _logger.LogInformation(1, "Administrator enabled Account.");
            }
            return RedirectToAction(nameof(Index), "User");
        }

        //
        // POST: /Manage/DisableAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DisableAccount2()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                if (user.IsEnabled == true)
                {
                    user.IsEnabled = false;
                    await _userManager.UpdateAsync(user);
                }
                _logger.LogInformation(1, "Administrator Disabled Account.");
            }
            return RedirectToAction(nameof(Index), "User");
        }


    }
}
