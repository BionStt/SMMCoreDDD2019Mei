using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSalesMarketing(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<SalesMarketingContext>(options =>
              options.UseSqlServer(connectionString));

            return services;
        }
    }
}
