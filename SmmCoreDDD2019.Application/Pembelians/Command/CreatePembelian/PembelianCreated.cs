using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.Pembelians.Command.CreatePembelian
{
    public class PembelianCreated : INotification
    {
        public string PembelianID { get; set; }

        public class PembelianCreatedHandler : INotificationHandler<PembelianCreated>
        {
            private readonly INotificationService _notification;

            public PembelianCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(PembelianCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }

    }
}
