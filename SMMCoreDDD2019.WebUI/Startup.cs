using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB;
using SmmCoreDDD2019.Application.Infrastructure;
using SmmCoreDDD2019.Application.Infrastructure.AutoMapper;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList;
using SmmCoreDDD2019.Common;
using SmmCoreDDD2019.Infrastructure;
using SmmCoreDDD2019.Persistence;
using SMMCoreDDD2019.WebUI.Models;
using NSwag.AspNetCore;
using System.Reflection;
using SmmCoreDDD2019.Common.Identity;
using Microsoft.AspNetCore.Identity;
using SmmCoreDDD2019.Infrastructure.Services;
using Newtonsoft.Json.Serialization;
using SmmCoreDDD2019.Common.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using SmmCoreDDD2019.CrossCutting.IoC;

namespace SMMCoreDDD2019.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Get Identity Default Options
            IConfigurationSection identityDefaultOptionsConfigurationSection = Configuration.GetSection("IdentityDefaultOptions");

            services.Configure<IdentityDefaultOptions>(identityDefaultOptionsConfigurationSection);
            //apakah ini tdk sama dengan dibawah ???
            var identityDefaultOptions = identityDefaultOptionsConfigurationSection.Get<IdentityDefaultOptions>();

            //configure passwordhash spt tdk guna 
            //services.Configure<PasswordHasherOptions>(options =>
            //    options.CompatibilityMode=PasswordHasherCompatibilityMode.IdentityV2

            //);

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
                {
                    // Password settings
                    options.Password.RequireDigit = identityDefaultOptions.PasswordRequireDigit;
                    options.Password.RequiredLength = identityDefaultOptions.PasswordRequiredLength;
                    options.Password.RequireNonAlphanumeric = identityDefaultOptions.PasswordRequireNonAlphanumeric;
                    options.Password.RequireUppercase = identityDefaultOptions.PasswordRequireUppercase;
                    options.Password.RequireLowercase = identityDefaultOptions.PasswordRequireLowercase;
                    options.Password.RequiredUniqueChars = identityDefaultOptions.PasswordRequiredUniqueChars;

                    // Lockout settings
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(identityDefaultOptions.LockoutDefaultLockoutTimeSpanInMinutes);
                    options.Lockout.MaxFailedAccessAttempts = identityDefaultOptions.LockoutMaxFailedAccessAttempts;
                    options.Lockout.AllowedForNewUsers = identityDefaultOptions.LockoutAllowedForNewUsers;

                    // User settings
                    options.User.RequireUniqueEmail = identityDefaultOptions.UserRequireUniqueEmail;

                    // email confirmation require
                    options.SignIn.RequireConfirmedEmail = identityDefaultOptions.SignInRequireConfirmedEmail;
                }
                )
               .AddEntityFrameworkStores<AppIdentityDbContext>()
               .AddDefaultTokenProviders();

            services.AddEntityFrameworkSqlServer();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.LoginPath = "/Account/Login2";
                options.LogoutPath = "/Account/Signout";
                options.Cookie = new CookieBuilder
                {
                    IsEssential = true // required for auth to work without explicit user consent; adjust to suit your privacy policy
                };

                // Cookie settings
                //options.Cookie.HttpOnly = identityDefaultOptions.CookieHttpOnly;
                //options.Cookie.Expiration = TimeSpan.FromDays(identityDefaultOptions.CookieExpiration);
                //options.LoginPath = identityDefaultOptions.LoginPath; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                //options.LogoutPath = identityDefaultOptions.LogoutPath; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                //options.AccessDeniedPath = identityDefaultOptions.AccessDeniedPath; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                //options.SlidingExpiration = identityDefaultOptions.SlidingExpiration;

            });

            // Get SendGrid configuration options
          //  services.Configure<SendGridOptions>(Configuration.GetSection("SendGridOptions"));

            // Get SMTP configuration options
           services.Configure<SmtpOptions>(Configuration.GetSection("SmtpOptions"));

            // Get Super Admin Default options
            services.Configure<SuperAdminDefaultOptions>(Configuration.GetSection("SuperAdminDefaultOptions"));

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            ////lokalisasi bahasa UI??
            //  services.AddLocalization(options => options.ResourcesPath = "Resources");

            /*
             Add supporting localization to Mvc and set Directory of Resources files
             For example all resourcess will be in ~/Resources/Controllers/AboutController.en-GB.resx
            */
            services.AddMvc()
                .AddViewLocalization(
                    LanguageViewLocationExpanderFormat.Suffix,
                    opts => { opts.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization();
            //services.AddMvc()
            //  .AddDataAnnotationsLocalization(options => {
            //            options.DataAnnotationLocalizerProvider = (type, factory) =>
            //                         factory.Create(typeof(SharedResource));
            //  });

            //setelan utk lokalisasi bahasa UI ??
            services.Configure<RequestLocalizationOptions>(
             opts => {
                     var supportedCultures = new List<CultureInfo>
                        {
                             new CultureInfo("en-US"),
                              new CultureInfo("id-ID")
                        };

                    opts.DefaultRequestCulture = new RequestCulture("en-US");
                    // Formatting numbers, dates, etc.
                    opts.SupportedCultures = supportedCultures;
                    // UI strings that we have localized.
                    opts.SupportedUICultures = supportedCultures;

                     /*
                       At example below your URL will be looks as this:
                       http://localhost:5000/?lang=es-MX&ui-lang=es-MX
                    */
                      // opts.RequestCultureProviders.Add(new QueryStringRequestCultureProvider() { QueryStringKey = "lang", UIQueryStringKey = "ui-lang" });

                 //opts.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(context => {
                 //    var settingService = context.RequestServices.GetService<Core.Service.SettingService>();
                 //    // My custom request culture logic
                 //    return Task.Run(() => new ProviderCultureResult(settingService.Get().Language));
                 //}));

             });

            services.AddMvc();
            // Add AutoMapper
            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });

            // .NET Native DI Abstraction
            RegisterServices(services);
                        
          

            // Add MediatR
            //services.AddMediatR(typeof(GetProductQueryHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetCustomersListQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
          //  services.AddMediatR();

            // Add DbContext using SQL Server Provider
            services.AddDbContext<SMMCoreDDD2019DbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019Connection")));

            services.AddDbContext<AppIdentityDbContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019IdentityConnection")));

          
            services
              .AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
              .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
              .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateCustomerCommandValidator>());

            services.AddMvc()
           .AddJsonOptions(options =>
           {
               options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                //pascal case json
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();

           });

            // Customise default API behavour
            //services.Configure<ApiBehaviorOptions>(options =>
            //{
            //    options.SuppressModelStateInvalidFilter = true;
            //});

            // In production, the Angular files will be served from this directory
            //services.AddSpaStaticFiles(configuration =>
            //{
            //    configuration.RootPath = "ClientApp/dist";
            //});


            //   services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        //buat belajar
        //https://www.tutorialsteacher.com/core/aspnet-core-logging
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        //{
        //    // other code remove for clarity 
        //    loggerFactory.AddFile("Logs/mylog-{Date}.txt");
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment() || env.IsStaging())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}
            //code removed for clarity 
            //https://www.tutorialsteacher.com/core/aspnet-core-exception-handling

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

          
            app.UseHttpsRedirection();
           
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseStaticFiles(); // For the wwwroot folder

            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //                        Path.Combine(Directory.GetCurrentDirectory(), @"Images")),
            //    RequestPath = new PathString("/app-images")
            //});
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Content")),
            //    RequestPath = new PathString("/Admin")
            //});
            //https://www.tutorialsteacher.com/core/aspnet-core-static-file

            //app.UseSwaggerUi3(settings =>
            //{
            //    settings.Path = "/api";
            //    settings.DocumentPath = "/api/specification.json";
            //});

            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "default",
                //    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                  name: "default",
                  template: "{controller=UserRole}/{action=UserProfile}/{id?}");
            });

            //app.UseSpa(spa =>
            //{
            //    // To learn more about options for serving an Angular SPA from ASP.NET Core,
            //    // see https://go.microsoft.com/fwlink/?linkid=864501

            //    spa.Options.SourcePath = "ClientApp";

            //    if (env.IsDevelopment())
            //    {
            //        spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
            //    }
            //});


        }

        private static void RegisterServices(IServiceCollection services)
        {
            // Adding dependencies from another layers (isolated from Presentation)
            NativeInjectorBootStrapper.RegisterServices(services);
        }

    }
}
