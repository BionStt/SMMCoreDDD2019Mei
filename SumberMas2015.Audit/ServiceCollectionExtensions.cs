using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.Audit.Domain.Repository;
using SumberMas2015.Audit.Infrastructure.Context;
using SumberMas2015.Audit.Infrastructure.Repository;
using SumberMas2015.Audit.ServiceApplication;
using SumberMas2015.Audit.ServiceApplication.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Audit
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuditStorage(this IServiceCollection services, string connectionString)
        {
            //  services.AddTransient<IDbConnection>(_ => new SqlConnection(connectionString));
            services.AddScoped<ISumberMasAudit, SumberMasAudit>();
            services.AddScoped<IAuditLogRepository, AuditLogRepository>();
            services.AddDbContext<AuditContext>(options =>
               options.UseSqlServer(connectionString, sqlOptions =>
               {
                   sqlOptions.EnableRetryOnFailure(
                       3,
                       TimeSpan.FromSeconds(300),
                       null);
               }));

            // services.BuildServiceProvider().GetService<AuditContext>().Database.Migrate();

            return services;

        }
    }
}
