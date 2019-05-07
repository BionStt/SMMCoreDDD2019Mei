using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;
namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.CreateDataPerusahaan
{
   public class DataPerusahaanCreated :INotification
    {
        public string DataPerusahanID { get; set; }
        public class DataPerusahaanCreatedHandler : INotificationHandler<DataPerusahaanCreated>
        {
            private readonly INotificationService _notification;

            public DataPerusahaanCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataPerusahaanCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }


    }
}
