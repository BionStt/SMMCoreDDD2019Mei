using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.CreateDataKontrakAsuransi
{
    public class DataKontrakAsuransiCreated : INotification
    {
        public int DataKontrakAsuransiID { get; set; }
        public class DataKontrakAsuransiCreatedHandler : INotificationHandler<DataKontrakAsuransiCreated>
        {
            private readonly INotificationService _notification;

            public DataKontrakAsuransiCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataKontrakAsuransiCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
