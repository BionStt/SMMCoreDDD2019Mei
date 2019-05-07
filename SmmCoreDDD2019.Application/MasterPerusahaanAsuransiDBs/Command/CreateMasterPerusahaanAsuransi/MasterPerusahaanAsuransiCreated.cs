using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.CreateMasterPerusahaanAsuransi
{
    public class MasterPerusahaanAsuransiCreated : INotification
    {
        public string MasterPerusahaanAsuransiID { get; set; }
        public class MasterPerusahaanAsuransiCreatedHandler : INotificationHandler<MasterPerusahaanAsuransiCreated>
        {
            private readonly INotificationService _notification;

            public MasterPerusahaanAsuransiCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(MasterPerusahaanAsuransiCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());

                // throw new NotImplementedException();
            }
        }
    }
}
