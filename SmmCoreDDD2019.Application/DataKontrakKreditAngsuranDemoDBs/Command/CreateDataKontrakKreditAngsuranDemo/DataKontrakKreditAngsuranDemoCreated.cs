using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.DataKontrakKreditAngsuranDemoDBs.Command.CreateDataKontrakKreditAngsuranDemo
{
    public class DataKontrakKreditAngsuranDemoCreated : INotification
    {
        public string DataKontrakKreditAngsuranDemoID { get; set; }

        public class DataKontrakKreditAngsuranDemoCreatedHandler : INotificationHandler<DataKontrakKreditAngsuranDemoCreated>
        {
            private readonly INotificationService _notification;

            public DataKontrakKreditAngsuranDemoCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataKontrakKreditAngsuranDemoCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                //  throw new NotImplementedException();
            }
        }
    }
}
