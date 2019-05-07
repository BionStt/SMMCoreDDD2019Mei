using System;
using System.Collections.Generic;
using System.Text;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.CreateDataPegawaiDataRiwayatPelatihan
{
  public  class DataPegawaiDataRiwayatPelatihanCreated:INotification
    {
        public string DataPegawaiDataRiwayatPelatihanID { get; set; }

        public class DataPegawaiDataRiwayatPelatihanCreatedHandler : INotificationHandler<DataPegawaiDataRiwayatPelatihanCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataRiwayatPelatihanCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataPegawaiDataRiwayatPelatihanCreated notification, CancellationToken cancellationToken)
            {

                await _notification.SendAsync(new Message());
                //   throw new NotImplementedException();
            }
        }


    }
}
