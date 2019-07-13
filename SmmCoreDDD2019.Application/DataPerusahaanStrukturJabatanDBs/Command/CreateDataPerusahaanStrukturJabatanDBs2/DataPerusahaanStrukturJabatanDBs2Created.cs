using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Command.CreateDataPerusahaanStrukturJabatanDBs2
{
    public class DataPerusahaanStrukturJabatanDBs2Created : INotification
    {
        public string DataPerusahaanStrukturJabatanID { get; set; }
        public class DataPerusahaanStrukturJabatanDBs2CreatedHandler : INotificationHandler<DataPerusahaanStrukturJabatanDBs2Created>
        {
            private readonly INotificationService _notification;
            public DataPerusahaanStrukturJabatanDBs2CreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataPerusahaanStrukturJabatanDBs2Created notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }

    }
}
