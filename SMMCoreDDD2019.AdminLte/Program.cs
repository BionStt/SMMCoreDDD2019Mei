using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using SumberMas2015.SalesMarketing.InfrastructureData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using SumberMas2015.Identity.Infrastructure.Context;
using SumberMas2015.Identity.Domain;
using SumberMas2015.Identity.ServiceApplication.Contracts;
using SumberMas2015.Identity.Infrastructure;

namespace SMMCoreDDD2019.AdminLte
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                   // var context = scope.ServiceProvider.GetService<ISMMCoreDDD2019DbContext>();
                  
                   //// contextIdentity.Database.Migrate();

                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                   //// var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                   var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();

                    var functional = services.GetRequiredService<IFunctional>();

                   //  var concreteContext = (SMMCoreDDD2019DbContext)context;
                   // // concreteContext.Database.Migrate();

                   // //  context.Database.Migrate(); //lama loading
                   //// SMMCoreDDD2019Initializer.Initialize(concreteContext);
                   // AppIdentityDbInitializar.Initialize(contextIdentity, functional).Wait();

                  
                    var contextIdentity = services.GetRequiredService<AppIdentityDbContext>();
                    AppIdentityDbInitializer.Initialize(contextIdentity, functional).Wait();

                    var SalesMarketingContext = services.GetRequiredService<SalesMarketingContext>();
                    DbInitializer.Initialize(SalesMarketingContext).Wait();

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();

                    logger.LogError(ex, "An error occurred while seeding the database.");
                    logger.LogError(ex.StackTrace, "An error occurred while seeding the database.");
                    logger.LogError(ex.InnerException, "An error occurred while seeding the database.");

                }



            }
            host.Run();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
             .ConfigureAppConfiguration((hostingContext, config) =>
             {
                 var env = hostingContext.HostingEnvironment;
                 config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                       .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true)
                       .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                 config.AddEnvironmentVariables();
             })
             .ConfigureLogging((hostingContext, logging) =>
             {
                 logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                 logging.AddConsole();
                 logging.AddDebug();
                 //logging.AddEventSourceLogger();
             }).UseStartup<Startup>();


    }
}
