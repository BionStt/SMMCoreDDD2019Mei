using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;


namespace SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Command.CreateMasterJenisJabatanDB
{
    public class MasterJenisJabatanCreated:INotification
    {
        public string MasterJenisJabatanID { get; set; }

        public class MasterJenisJabatanCreatedHandler : INotificationHandler<MasterJenisJabatanCreated>
        {
            private readonly INotificationService _notification;

            public MasterJenisJabatanCreatedHandler(INotificationService notification)
            {
                _notification = notification;

            }

            public async Task Handle(MasterJenisJabatanCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }
        }
    }
}
