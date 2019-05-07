using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
namespace SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.CreatePermohonanFaktur
{
    public class PermohonanFakturCreated : INotification
    {
        public string PermohonanFakturID { get; set; }
        public class PermohonanFakturCreatedHandler : INotificationHandler<PermohonanFakturCreated>
        {
            private readonly INotificationService _notification;

            public PermohonanFakturCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(PermohonanFakturCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
