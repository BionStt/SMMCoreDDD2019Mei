using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.CreateDataKontrakKredit
{
    public class DataKontrakKreditCreated : INotification
    {
        public string DataKontrakKreditID { get; set; }

        public class DataKontrakKreditCreatedHandler : INotificationHandler<DataKontrakKreditCreated>
        {
            private readonly INotificationService _notification;

            public DataKontrakKreditCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataKontrakKreditCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                //  throw new NotImplementedException();
            }
        }
    }
}
