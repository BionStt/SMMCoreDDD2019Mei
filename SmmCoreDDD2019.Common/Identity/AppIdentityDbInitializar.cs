using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Services;

namespace SmmCoreDDD2019.Common.Identity
{
    public class AppIdentityDbInitializar
    {
        public static async Task Initialize(AppIdentityDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "ADMINISTRATOR";
            string desc1 = "This is the administrator role";

            string role2 = "ADMIN";
            string desc2 = "This is the admin role";

            string role3 = "MARCO";
            string desc3 = "This is the Marco role";

            string role4 = "MARKETING";
            string desc4 = "This is the Marketing role";

            string password = "Smm@123456";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role3) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role4) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("Bion") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Bion",
                    Name = "Bion",
                    Email = "sutanto.gasali@gmail.com",
                    PhoneNumber = "08111806368"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("Bion2") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Bion2",
                    Name = "Bion2",
                    Email = "sutanto.gasali@gmail.com",
                    PhoneNumber = "08111806368"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
                adminId2 = user.Id;
            }

                     


        }

        public static async Task Initialize(AppIdentityDbContext context,
         IFunctional functional)
        {
            context.Database.EnsureCreated();

            //check for users
            if (context.ApplicationUser.Any())
            {
                return; //if user is not empty, DB has been seed
            }

            //init app with super admin user
            await functional.CreateDefaultSuperAdmin();

            //init app data
          //  await functional.InitAppData();

        }


    }
}
