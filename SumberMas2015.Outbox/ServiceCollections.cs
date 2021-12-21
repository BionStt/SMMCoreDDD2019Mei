using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.Outbox.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Outbox
{
    public static class ServiceCollections
    {
        public static IServiceCollection AddOutBoxModule(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OutboxDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
