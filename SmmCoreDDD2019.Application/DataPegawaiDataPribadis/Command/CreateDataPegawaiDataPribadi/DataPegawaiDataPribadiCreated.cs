using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;


namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.CreateDataPegawaiDataPribadi
{
    public class DataPegawaiDataPribadiCreated:INotification
    {
        public string DataPegawaiID { get; set; }

        public class DataPegawaiDataPribadiCreatedHandler : INotificationHandler<DataPegawaiDataPribadiCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataPribadiCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataPegawaiDataPribadiCreated notification, CancellationToken cancellationToken)
            {

                await _notification.SendAsync(new Message());
                //   throw new NotImplementedException();
            }
        }
    }
}
