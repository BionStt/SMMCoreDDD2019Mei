﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Command.CreateDataPerusahaanStrukturJabatan
{
    public class DataPerusahaanStrukturJabatanCreated : INotification
    {
        public string DataPerusahaanStrukturJabatanID { get; set; }
        public class DataPerusahaanStrukturJabatanCreatedHandler : INotificationHandler<DataPerusahaanStrukturJabatanCreated>
        {
            private readonly INotificationService _notification;
            public DataPerusahaanStrukturJabatanCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataPerusahaanStrukturJabatanCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }
        }
    }
}
