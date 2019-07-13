using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Command.CreateDataPerusahaanOrgChartDB
{
    public class DataPerusahaanOrgChartDBCreated : INotification
    {
        public string DataPerusahaanOrgChartID { get; set; }
        public class DataPerusahaanOrgChartDBCreatedHandler : INotificationHandler<DataPerusahaanOrgChartDBCreated>
        {
            private readonly INotificationService _notification;
            public DataPerusahaanOrgChartDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataPerusahaanOrgChartDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }

    }
}
