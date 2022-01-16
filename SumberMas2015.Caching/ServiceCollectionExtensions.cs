using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Caching
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSumberMasCache(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ISumberMasCache, SumberMasMemoryCache>();
            return services;
        }
    }
}
