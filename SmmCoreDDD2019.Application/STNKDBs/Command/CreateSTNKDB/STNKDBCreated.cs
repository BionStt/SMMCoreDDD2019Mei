using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;

namespace SmmCoreDDD2019.Application.STNKDBs.Command.CreateSTNKDB
{
    public class STNKDBCreated : INotification
    {
        public string STNKDBID { get; set; }
        public class STNKDBCreatedHandler : INotificationHandler<STNKDBCreated>
        {
            private readonly INotificationService _notification;

            public STNKDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(STNKDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }

    }
}
