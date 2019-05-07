using System;
using System.Collections.Generic;
using System.Text;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.CreateMasterLeasingDb
{
   public class CreateMasterLeasingDbCreated:INotification
    {
        public string MasterLeasingID { get; set; }

        public class CreateMasterLeasingDbCreatedHandler : INotificationHandler<CreateMasterLeasingDbCreated>
        {
            private readonly INotificationService _notification;
            public CreateMasterLeasingDbCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(CreateMasterLeasingDbCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
               // throw new NotImplementedException();
            }
        }

    }
}
