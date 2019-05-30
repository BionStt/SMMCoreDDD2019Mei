using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;


namespace SmmCoreDDD2019.Application.DataPegawaiDataAwardDBs.Command.CreateDataPegawaiDataAward
{
    public class DataPegawaiDataAwardCreated : INotification
    {
        public string DataPegawaiDataAwardID { get; set; }

        public class DataPegawaiDataAwardCreatedHandler : INotificationHandler<DataPegawaiDataAwardCreated>
        {
            private readonly INotificationService _notification;
            public DataPegawaiDataAwardCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataPegawaiDataAwardCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }

    }
}
