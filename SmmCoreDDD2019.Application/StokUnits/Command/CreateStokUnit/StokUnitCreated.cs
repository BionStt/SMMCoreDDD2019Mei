using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;

namespace SmmCoreDDD2019.Application.StokUnits.Command.CreateStokUnit
{
    public class StokUnitCreated : INotification
    {
        public string StokUnitID { get; set; }
        public class StokUnitCreatedHandler : INotificationHandler<StokUnitCreated>
        {
            private readonly INotificationService _notification;

            public StokUnitCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(StokUnitCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
