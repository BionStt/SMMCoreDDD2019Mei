using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmmCoreDDD2019.Common.Identity;

[assembly: HostingStartup(typeof(SMMCoreDDD2019.WebAdminLte.Areas.Identity.IdentityHostingStartup))]
namespace SMMCoreDDD2019.WebAdminLte.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}