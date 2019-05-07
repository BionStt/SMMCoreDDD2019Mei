using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.CreatePejualanDetail
{
    public class PenjualanDetailCreated : INotification
    {
        public string PenjualanDetailID { get; set; }
        public class PenjualanDetailCreatedHandler : INotificationHandler<PenjualanDetailCreated>
        {
            private readonly INotificationService _notification;

            public PenjualanDetailCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(PenjualanDetailCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
