using System;
using System.Collections.Generic;
using System.Text;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.CreateDataPerusahaanCabang
{
    public class DataPerusahaanCabangCreated:INotification
    {
        public string DataPerusahaanCabangID { get; set; }

        public class DataPerusahaanCabangCreatedHandler : INotificationHandler<DataPerusahaanCabangCreated>
        {
            private readonly INotificationService _notification;

            public DataPerusahaanCabangCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataPerusahaanCabangCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());

                //throw new NotImplementedException();
            }
        }

    }
}
