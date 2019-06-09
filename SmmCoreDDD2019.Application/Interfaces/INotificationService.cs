using SmmCoreDDD2019.Application.Notifications.Models;

using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
     
    }
}
