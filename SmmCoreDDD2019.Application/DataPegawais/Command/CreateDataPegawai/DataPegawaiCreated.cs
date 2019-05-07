using System;
using System.Collections.Generic;
using System.Text;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPegawais.Command.CreateDataPegawai
{
   public class DataPegawaiCreated:INotification
    {
        public string DataPegawaiID { get; set; }

        public class DataPegawaiCreatedHandler : INotificationHandler<DataPegawaiCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public  async Task Handle(DataPegawaiCreated notification, CancellationToken cancellationToken)
            {

                await _notification.SendAsync(new Message());
                //   throw new NotImplementedException();
            }
        }


    }
}
