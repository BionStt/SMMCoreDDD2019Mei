using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.HumanCapital.InfrastructureData.Context;

namespace SumberMas2015.HumanCapital
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHumanCapital(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<HumanCapitalContext>(options =>
              options.UseSqlServer(connectionString));

            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
