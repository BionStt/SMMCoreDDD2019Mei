using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;


namespace SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.CreateDataSPKBaruDB
{
    public class DataSPKBaruDBCreated:INotification
    {
        public string DataSPKBaruDBID { get; set; }
        public class DataSPKBaruDBCreatedHandler : INotificationHandler<DataSPKBaruDBCreated>
        {
            private readonly INotificationService _notification;

            public DataSPKBaruDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataSPKBaruDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());

                //  throw new NotImplementedException();
            }
        }
    }
}
