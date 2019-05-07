using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Infrastructure
{
    public class NotificationService : INotificationService
    {
       
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
            //  throw new NotImplementedException();
        }

      
    }
}
