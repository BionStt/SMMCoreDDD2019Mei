using Microsoft.AspNetCore.Hosting;

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