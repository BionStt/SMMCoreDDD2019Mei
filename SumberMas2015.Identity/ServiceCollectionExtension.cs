using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.Identity.Domain;
using SumberMas2015.Identity.Infrastructure.Context;
using SumberMas2015.Identity.ServiceApplication;
using SumberMas2015.Identity.ServiceApplication.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Identity
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services, string connectionString, IConfiguration configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddTransient<HttpClient>();

            services.AddTransient<IRoles, Roles>();
            services.AddTransient<IFunctional, Functional>();


            services.AddDbContext<AppIdentityDbContext>(
                options =>
                options.UseSqlServer(connectionString)
                //  options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019IdentityConnection"))
                //options.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
                //{
                //    sqlOptions.EnableRetryOnFailure(
                //        maxRetryCount: 5,
                //        maxRetryDelay: TimeSpan.FromSeconds(30),
                //        errorNumbersToAdd: null);
                //})
                );

            // Get Identity Default Options
            IConfigurationSection identityDefaultOptionsConfigurationSection = configuration.GetSection("IdentityDefaultOptions");

            services.Configure<IdentityDefaultOptions>(identityDefaultOptionsConfigurationSection);
            //apakah ini tdk sama dengan dibawah ???
            var identityDefaultOptions = identityDefaultOptionsConfigurationSection.Get<IdentityDefaultOptions>();
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
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+";

                // email confirmation require
                options.SignIn.RequireConfirmedEmail = identityDefaultOptions.SignInRequireConfirmedEmail;
                options.SignIn.RequireConfirmedAccount = identityDefaultOptions.RequireConfirmedAccount;
                options.SignIn.RequireConfirmedPhoneNumber = identityDefaultOptions.RequireConfirmedPhoneNumber;

                // options.User.RequireUniqueEmail = identityDefaultOptions.UserRequireUniqueEmail;
            })
             .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            // cookie settings
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = identityDefaultOptions.CookieHttpOnly;
                // options.Cookie.Expiration = TimeSpan.FromDays(identityDefaultOptions.CookieExpiration);
                options.LoginPath = identityDefaultOptions.LoginPath; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                options.LogoutPath = identityDefaultOptions.LogoutPath; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = identityDefaultOptions.AccessDeniedPath; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                options.SlidingExpiration = identityDefaultOptions.SlidingExpiration;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(identityDefaultOptions.ExpireTimeSpan);

            });

            // services.AddEntityFrameworkSqlServer();

            // Get SMTP configuration options
            services.Configure<SmtpOptions>(configuration.GetSection("SmtpOptions"));

            // Get Super Admin Default options
            services.Configure<SuperAdminDefaultOptions>(configuration.GetSection("SuperAdminDefaultOptions"));


            return services;
        }


    }
}
