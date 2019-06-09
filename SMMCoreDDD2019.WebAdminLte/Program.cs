using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using SmmCoreDDD2019.Persistence;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Common.Identity;
using Microsoft.AspNetCore.Identity;
using SmmCoreDDD2019.Infrastructure.Services;
using SmmCoreDDD2019.Common.Services;
using SmmCoreDDD2019.Application.Interfaces;

namespace SMMCoreDDD2019.WebAdminLte
{ 
   
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateWebHostBuilder(args).Build().Run();
        //}

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();


        //BUAT BELAJAR
        //https://www.tutorialsteacher.com/core/aspnet-core-program
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = scope.ServiceProvider.GetService<ISMMCoreDDD2019DbContext>();
                    // var contextIdentity = scope.ServiceProvider.GetService<AppIdentityDbContext>();
                    // var userManager = scope.ServiceProvider.GetService<UserManager<ApplicationUser>>();
                    //var roleManager = scope.ServiceProvider.GetService<RoleManager<ApplicationRole>>();


                    var contextIdentity = services.GetRequiredService<AppIdentityDbContext>();
                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
                    var functional = services.GetRequiredService<IFunctional>();
                    //  var functional2 = services.GetRequiredService<INetcoreService>();

                    //2 perintah code dibawah ini supaya otomatis migrate database
                    // context.Database.Migrate();
                    // contextIdentity.Database.Migrate();
                    var concreteContext = (SMMCoreDDD2019DbContext)context;
                    concreteContext.Database.Migrate();
                
                    SMMCoreDDD2019Initializer.Initialize(concreteContext);
                    //  AppIdentityDbInitializar.Initialize(contextIdentity, userManager, roleManager).Wait();
                    AppIdentityDbInitializar.Initialize(contextIdentity, functional).Wait();
                    //pasword di appsetting
                }
                catch (Exception ex)
                {
                    //buat belajar
                    //https://www.tutorialsteacher.com/core/fundamentals-of-logging-in-dotnet-core
                    //https://msdn.microsoft.com/magazine/mt694089

                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database.");
                    //logger.LogInformation(ex,"Logging information.");
                    //logger.LogCritical(ex,"Logging critical information.");
                    //logger.LogDebug(ex,"Logging debug information.");
                    //logger.LogError(ex,"Logging error information.");
                    //logger.LogTrace(ex,"Logging trace");
                    //logger.LogWarning(ex,"Logging warning.");

                }
            }

            host.Run();


            // CreateWebHostBuilder(args).Build().Run();
        }
        //log level severity: Trace = 0, Debug = 1, Information = 2, Warning = 3, Error = 4, Critical = 5
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
               .UseKestrel()
               .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                          .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true)
                          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                    config.AddEnvironmentVariables();
                })

                //buat belajar
                //https://www.tutorialsteacher.com/core/aspnet-core-logging
                //.ConfigureLogging(logBuilder =>
                //{
                //    logBuilder.ClearProviders(); // removes all providers from LoggerFactory
                //    logBuilder.AddConsole();
                //    logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
                //})

                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                    //logging.AddEventSourceLogger();


                })
                .UseStartup<Startup>();




    }
}
