using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {

            // Add DbContext using SQL Server Provider
            services.AddDbContext<ISMMCoreDDD2019DbContext, SMMCoreDDD2019DbContext>(options =>
                options.UseSqlServer(connectionString)

                );


            return services;

        }
    }
}
