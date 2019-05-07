using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
namespace SmmCoreDDD2019.Application.BPKBDBs.Command.CreateBPKBDB
{
    public class BPKBDBCreated : INotification
    {
        public string BPKBID { get; set; }
        public class BPKBDBCreatedHandler : INotificationHandler<BPKBDBCreated>
        {
            private readonly INotificationService _notification; public BPKBDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(BPKBDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}

