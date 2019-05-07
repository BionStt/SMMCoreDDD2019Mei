﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.CreateDataPegawaiFoto
{
   public class DataPegawaiFotoCreated:INotification
    {
        public string DataPegawaiFotoID { get; set; }

        public class DataPegawaiFotoCreatedHandler : INotificationHandler<DataPegawaiFotoCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiFotoCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataPegawaiFotoCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                //throw new NotImplementedException();
            }
        }
    }
}
