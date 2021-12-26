using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.Reflection;

namespace SumberMas2015.IntegrationEvent
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddIntegrationEventModule(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;

        }
    }
}
