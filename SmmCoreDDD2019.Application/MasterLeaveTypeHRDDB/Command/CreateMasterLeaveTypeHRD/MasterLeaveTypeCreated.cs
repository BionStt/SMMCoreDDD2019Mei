using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;

namespace SmmCoreDDD2019.Application.MasterLeaveTypeHRDDB.Command.CreateMasterLeaveTypeHRD
{
    public class MasterLeaveTypeCreated : INotification
    {
        public string MasterLeaveTypeID { get; set; }
        public class CreateMasterLeaveTypeCreatedHandler : INotificationHandler<MasterLeaveTypeCreated>
        {
            private readonly INotificationService _notification;
            public CreateMasterLeaveTypeCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

          public async Task Handle(MasterLeaveTypeCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }


    }
}
