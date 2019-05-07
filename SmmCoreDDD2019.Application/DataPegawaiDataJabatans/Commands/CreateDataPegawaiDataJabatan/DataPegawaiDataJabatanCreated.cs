using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.CreateDataPegawaiDataJabatan
{
    public class DataPegawaiDataJabatanCreated:INotification
    {
        public string DataPegawaiDataJabatanID { get; set; }

        public class DataPegawaiDataJabatanCreatedHandler : INotificationHandler<DataPegawaiDataJabatanCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataJabatanCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataPegawaiDataJabatanCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
              //  throw new NotImplementedException();
            }
        }

    }
}
