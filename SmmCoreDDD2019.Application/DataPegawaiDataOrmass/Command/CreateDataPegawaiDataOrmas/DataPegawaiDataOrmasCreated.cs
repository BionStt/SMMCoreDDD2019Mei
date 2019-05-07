using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.CreateDataPegawaiDataOrmas
{
    public class DataPegawaiDataOrmasCreated:INotification
    {
        public string DataPegawaiDataOrmassID { get; set; }

        public class DataPegawaiDataOrmasCreatedHandler : INotificationHandler<DataPegawaiDataOrmasCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataOrmasCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataPegawaiDataOrmasCreated notification, CancellationToken cancellationToken)
            {

                await _notification.SendAsync(new Message());
                //   throw new NotImplementedException();
            }
        }

    }
}
