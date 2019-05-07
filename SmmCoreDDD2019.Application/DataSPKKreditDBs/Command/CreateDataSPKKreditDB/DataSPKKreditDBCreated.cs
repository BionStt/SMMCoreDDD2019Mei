using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.CreateDataSPKKreditDB
{
    public class DataSPKKreditDBCreated:INotification
    {
        public string DataSPKKreditDBID { get; set; }
        public class DataSPKKreditDBCreatedHandler : INotificationHandler<DataSPKKreditDBCreated>
        {
            private readonly INotificationService _notification;

            public DataSPKKreditDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataSPKKreditDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }
        }
    }
}
