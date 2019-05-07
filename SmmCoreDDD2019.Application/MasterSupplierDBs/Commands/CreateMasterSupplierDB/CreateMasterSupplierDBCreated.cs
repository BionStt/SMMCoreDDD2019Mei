using System;
using System.Collections.Generic;
using System.Text;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;
namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.CreateMasterSupplierDB
{
   public class CreateMasterSupplierDBCreated:INotification
    {
        public string MasterSupplierID { get; set; }

        public class MasterSupplierCreatedHandler : INotificationHandler<CreateMasterSupplierDBCreated>
        {
            private readonly INotificationService _notification;

            public MasterSupplierCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(CreateMasterSupplierDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());

                // throw new NotImplementedException();
            }
        } 


    }
}
