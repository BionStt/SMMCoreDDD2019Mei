using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SmmCoreDDD2019.Application
{
    public static class MediatorExtensions
    {
        public static IServiceCollection AddMediatorHandlers(this IServiceCollection services, Assembly assembly)
        {
            var neededTypes = new[] { typeof(IRequestHandler<,>), typeof(IRequestHandler<>) };
            var classTypes = assembly.ExportedTypes.Select(x => x.GetTypeInfo()).Where(x => x.IsClass && !x.IsAbstract);

            foreach (var type in classTypes)
            {
                var interfaces = type.ImplementedInterfaces.Select(x => x.GetTypeInfo());

                var iFiltered = interfaces.Where(x => x.IsGenericType && neededTypes.Contains(x.GetGenericTypeDefinition()));

                foreach (var handlerType in iFiltered)
                    services.AddTransient(handlerType.AsType(), type.AsType());
            }

            return services;
        }
    }
}
