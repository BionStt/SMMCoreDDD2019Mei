using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SumberMas2015.Notification.Contracts;
using SumberMas2015.Notification.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Notification
{
    public static class ServiceExtensionCollections
    {
        public static IServiceCollection AddNotification(this IServiceCollection services, IConfiguration configuration)
        {


            //var section = configuration.GetSection(nameof(SumberMas2015.Notification));
            // var settings = section.Get<EmailSettings>();
            // services.Configure<EmailSettings>(section);
           
            //var appSettings = configuration.GetSection(nameof(EmailSettings));
            //services.Configure<EmailSettings>(appSettings);

            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<ISmsSender, SmsSender>();

            return services;
        }


    }
}
