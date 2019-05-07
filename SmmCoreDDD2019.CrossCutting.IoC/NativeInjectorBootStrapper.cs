using MediatR;
using MediatR.Pipeline;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SmmCoreDDD2019.Application.Infrastructure;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Common;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Services;
using SmmCoreDDD2019.Infrastructure;
using SmmCoreDDD2019.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //services.Add(new ServiceDescriptor(typeof(ILog), new MyConsoleLogger()));    // singleton
            // services.Add(new ServiceDescriptor(typeof(ILog), typeof(MyConsoleLogger), ServiceLifetime.Transient)); // Transient
            //services.Add(new ServiceDescriptor(typeof(ILog), typeof(MyConsoleLogger), ServiceLifetime.Scoped));    // Scoped
            //https://www.tutorialsteacher.com/core/dependency-injection-in-aspnet-core
            //https://www.tutorialsteacher.com/core/internals-of-builtin-ioc-container-in-aspnet-core
            //BUAT BELAJAR

            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<INumberSequence, SmmCoreDDD2019.Common.Services.NumberSequence>();
            services.AddTransient<IRoles, Roles>();
            services.AddTransient<IFunctional, Functional>();

            // Add framework services.
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<IDateTime, MachineDateTime>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<ApplicationSignInManager>();
            services.AddTransient<ISmsSender, SmsSender>();

            // Add MediatR
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            // Domain Bus (Mediator)
            //services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            //services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            //services.AddScoped<ICustomerAppService, CustomerAppService>();

            // Domain - Commands
            //services.AddScoped<IRequestHandler<RegisterNewCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Identity Services
            //services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            //services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // Infra - Identity
            //services.AddScoped<IUser, AspNetUser>();
        }
    }
}
