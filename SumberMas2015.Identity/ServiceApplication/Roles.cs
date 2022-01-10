using Microsoft.AspNetCore.Identity;
using SumberMas2015.Identity.Domain;
using SumberMas2015.Identity.Pages;
using SumberMas2015.Identity.ServiceApplication.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Identity.ServiceApplication
{
    public class Roles : IRoles
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public Roles(RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task GenerateRolesFromPagesAsync()
        {
            Type t = typeof(MainMenu);
            foreach (Type item in t.GetNestedTypes())
            {
                foreach (var itm in item.GetFields())
                {
                    if (itm.Name.Contains("RoleName"))
                    {
                        string roleName = (string)itm.GetValue(item);
                        if (!await _roleManager.RoleExistsAsync(roleName))
                            await _roleManager.CreateAsync(new ApplicationRole(roleName));
                    }
                }
            }
        }
        public async Task GenerateRolesFromPagesAsync2()
        {
            Type t = typeof(Pages.Pages);
            foreach (Type item in t.GetNestedTypes())
            {
                foreach (var itm in item.GetFields())
                {
                    if (itm.Name.Contains("Role"))
                    {
                        string roleName = (string)itm.GetValue(item);
                        if (!await _roleManager.RoleExistsAsync(roleName))
                            await _roleManager.CreateAsync(new ApplicationRole(roleName));
                    }
                }
            }
        }

        public async Task AddToRoles(string applicationUserId)
        {
            var user = await _userManager.FindByIdAsync(applicationUserId);
            if (user != null)
            {
                var roles = _roleManager.Roles;
                List<string> listRoles = new List<string>();
                foreach (var item in roles)
                {
                    listRoles.Add(item.Name);
                }
                await _userManager.AddToRolesAsync(user, listRoles);
            }
        }
        public async Task UpdateRoles(ApplicationUser appUser,
           ApplicationUser currentLoginUser)
        {
            try
            {
                IList<string> roles = await _userManager.GetRolesAsync(appUser);
                foreach (var item in roles)
                {
                    if (!item.Contains("Line"))
                    {
                        await _userManager.RemoveFromRoleAsync(appUser, item);
                    }

                }

                Type t = appUser.GetType();
                foreach (System.Reflection.PropertyInfo item in t.GetProperties())
                {
                    if (item.Name.Contains("Role"))
                    {
                        bool vlue = (bool)item.GetValue(appUser, null);
                        if (vlue)
                        {
                            string roleName = item.Name.Replace("Role", "");
                            if (!await _roleManager.RoleExistsAsync(roleName))
                                await _roleManager.CreateAsync(new ApplicationRole(roleName));
                            await _userManager.AddToRoleAsync(appUser, roleName);
                        }
                    }
                }




            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
