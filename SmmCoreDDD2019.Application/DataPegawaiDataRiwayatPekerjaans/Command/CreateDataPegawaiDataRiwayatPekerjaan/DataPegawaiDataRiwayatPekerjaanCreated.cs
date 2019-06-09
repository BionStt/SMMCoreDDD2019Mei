using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;


namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.CreateDataPegawaiDataRiwayatPekerjaan
{
    public class DataPegawaiDataRiwayatPekerjaanCreated:INotification
    {
        public string DatapegawaiDataRiwayatPekerjaanID { get; set; }

        public class DataPegawaiDataRiwayatPekerjaanCreatedHandler : INotificationHandler<DataPegawaiDataRiwayatPekerjaanCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataRiwayatPekerjaanCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataPegawaiDataRiwayatPekerjaanCreated notification, CancellationToken cancellationToken)
            {

                await _notification.SendAsync(new Message());
                //   throw new NotImplementedException();
            }
        }
    }
}
