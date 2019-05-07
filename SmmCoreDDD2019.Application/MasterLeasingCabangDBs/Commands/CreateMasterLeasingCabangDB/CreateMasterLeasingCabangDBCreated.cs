using System;
using System.Collections.Generic;
using System.Text;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.CreateMasterLeasingCabangDB
{
   public class CreateMasterLeasingCabangDBCreated:INotification
    {
        public string MasterLeasngCabangID { get; set; }
        public class CreateMasterLeasingCabangDBCreatedHandler : INotificationHandler<CreateMasterLeasingCabangDBCreated>
        {
            private readonly INotificationService _notification;

            public CreateMasterLeasingCabangDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(CreateMasterLeasingCabangDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }
        }
    }
}
