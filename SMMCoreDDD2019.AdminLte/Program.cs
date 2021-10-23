using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Services;
using SmmCoreDDD2019.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    var context = scope.ServiceProvider.GetService<ISMMCoreDDD2019DbContext>();
                    var contextIdentity = services.GetRequiredService<AppIdentityDbContext>();
                   // contextIdentity.Database.Migrate();

                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                   // var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                   var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();

                    var functional = services.GetRequiredService<IFunctional>();

                     var concreteContext = (SMMCoreDDD2019DbContext)context;
                    // concreteContext.Database.Migrate();

                    //  context.Database.Migrate(); //lama loading
                   // SMMCoreDDD2019Initializer.Initialize(concreteContext);
                    AppIdentityDbInitializar.Initialize(contextIdentity, functional).Wait();

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