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
   public class MasterLeasingCabangDBCreated : INotification
    {
        public string MasterLeasngCabangID { get; set; }
        public class MasterLeasingCabangDBCreatedHandler : INotificationHandler<MasterLeasingCabangDBCreated>
        {
            private readonly INotificationService _notification;

            public MasterLeasingCabangDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(MasterLeasingCabangDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }
        }
    }
}
