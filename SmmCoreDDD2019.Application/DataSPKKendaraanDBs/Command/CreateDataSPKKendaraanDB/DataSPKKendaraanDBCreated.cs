using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;


namespace SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.CreateDataSPKKendaraanDB
{
    public class DataSPKKendaraanDBCreated : INotification
    {
        public string DataSPKKendaraanDBID { get; set; }
        public class DataSPKKendaraanDBCreatedHandler : INotificationHandler<DataSPKKendaraanDBCreated>
        {
            private readonly INotificationService _notification;

            public DataSPKKendaraanDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataSPKKendaraanDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());

                //  throw new NotImplementedException();
            }
        }
    }
}
