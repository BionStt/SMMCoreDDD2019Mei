using SumberMas2015.Identity.Infrastructure.Context;
using SumberMas2015.Identity.ServiceApplication.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Identity.Infrastructure
{
    public static class AppIdentityDbInitializer
    {
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
           // await functional.InitAppData();

        }
    }
}
