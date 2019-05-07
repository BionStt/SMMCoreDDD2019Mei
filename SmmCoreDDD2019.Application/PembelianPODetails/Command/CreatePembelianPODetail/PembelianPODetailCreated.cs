using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.PembelianPODetails.Command.CreatePembelianPODetail
{
    public class PembelianPODetailCreated : INotification
    {
        public string PembelianPoDetailID { get; set; }

        public class PembelianPODetailCreatedHandler : INotificationHandler<PembelianPODetailCreated>
        {
            private readonly INotificationService _notification;

            public PembelianPODetailCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(PembelianPODetailCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
