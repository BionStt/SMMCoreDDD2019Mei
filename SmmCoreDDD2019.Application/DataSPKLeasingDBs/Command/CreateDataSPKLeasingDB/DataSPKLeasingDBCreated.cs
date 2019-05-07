using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.CreateDataSPKLeasingDB
{
    public class DataSPKLeasingDBCreated:INotification
    {
        public string DataSPKLeasingDBID { get; set; }
        public class DataSPKLeasingDBCreatedHandler : INotificationHandler<DataSPKLeasingDBCreated>
        {
            private readonly INotificationService _notification;

            public DataSPKLeasingDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataSPKLeasingDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());


                // throw new NotImplementedException();
            }
        }

    }
}
