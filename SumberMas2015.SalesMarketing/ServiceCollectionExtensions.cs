using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.SalesMarketing.EventBus;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.InfrastructureData.EventBus;
using SumberMas2015.SalesMarketing.InfrastructureData.Processing.InternalCommands;
using SumberMas2015.SalesMarketing.ServiceApplication.Configuration.InternalCommands;
using SumberMas2015.SalesMarketing.WorkerProcess;

namespace SumberMas2015.SalesMarketing
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSalesMarketing(this IServiceCollection services, string connectionString)
        {
            //var assembly = AppDomain.CurrentDomain.Load("Data");
            //services.AddMediatR(assembly);
            //  services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<SalesMarketingContext>(options =>
              options.UseSqlServer(connectionString));

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<ICommandsScheduler, CommandsScheduler>();

            services.AddScoped<ISalesMarketingEventBus, SalesMarketingEventBus>();

         //   services.AddHostedService<SalesMarketingInternalCommandsWorker>();
           // services.AddHostedService<SalesMarketingOutBoxWorker>();


            return services;
        }
    }
}
