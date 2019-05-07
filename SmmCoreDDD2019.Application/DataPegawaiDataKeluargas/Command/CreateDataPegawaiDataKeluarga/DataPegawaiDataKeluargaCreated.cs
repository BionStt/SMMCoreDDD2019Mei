using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.CreateDataPegawaiDataKeluarga
{
    public class DataPegawaiDataKeluargaCreated:INotification
    {
        public string DataPegawaiDataKeluargaID { get; set; }

        public class DataPegawaiDataKeluargaCreatedHandler : INotificationHandler<DataPegawaiDataKeluargaCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataKeluargaCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataPegawaiDataKeluargaCreated notification, CancellationToken cancellationToken)
            {

                await _notification.SendAsync(new Message());
                //   throw new NotImplementedException();
            }
        }
    }
}
