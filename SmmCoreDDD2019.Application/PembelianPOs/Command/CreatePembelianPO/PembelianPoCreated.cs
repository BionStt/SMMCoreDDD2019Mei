using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;


namespace SmmCoreDDD2019.Application.PembelianPOs.Command.CreatePembelianPO
{
    public class PembelianPoCreated : INotification
    {
        public string PembelianPoID { get; set; }
        public class PembelianPoCreatedHandler : INotificationHandler<PembelianPoCreated>
        {
            private readonly INotificationService _notification;

            public PembelianPoCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(PembelianPoCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());

               
            }

          
        }

    }
}
