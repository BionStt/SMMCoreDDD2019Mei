using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;

namespace SmmCoreDDD2019.Application.MasterAllowanceTypeDB.Command.CreateMasterAllowanceTypeDB
{
    public class MasterAllowanceTypeDBCreated : INotification
    {
        public string MasterAllowanceTypeID { get; set; }

        public class MasterAllowanceTypeDBCreatedHandler : INotificationHandler<MasterAllowanceTypeDBCreated>
        {
            private readonly INotificationService _notification;

            public MasterAllowanceTypeDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;

            }

            public async Task Handle(MasterAllowanceTypeDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }

           
        }

    }
}
