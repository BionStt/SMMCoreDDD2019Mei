using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;

namespace SmmCoreDDD2019.Application.PembelianDetails.Command.CreatePembelianDetail
{
    public class PembelianDetailCreated : INotification
    {
        public string PembelianDetailID { get; set; }

        public class PembelianDetailCreatedHandler : INotificationHandler<PembelianDetailCreated>
        {
            private readonly INotificationService _notification;

            public PembelianDetailCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(PembelianDetailCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }

    }
}
