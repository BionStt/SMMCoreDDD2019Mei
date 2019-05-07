using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
namespace SmmCoreDDD2019.Application.Penjualans.Command.CreatePenjualan
{
    public class PenjualanCreated : INotification
    {
        public string PenjualanID { get; set; }
        public class PenjualanCreatedHandler : INotificationHandler<PenjualanCreated>
        {
            private readonly INotificationService _notification;

            public PenjualanCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(PenjualanCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }

    }
}
