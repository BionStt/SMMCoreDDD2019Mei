﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.CreateDataPegawaiDataRiwayatPendidikan
{
    public class DataPegawaiDataRiwayatPendidikanCreate : INotification
    {
        public string DataPegawaiDataRiwayatPendidikanID { get; set; }
        public class DataPegawaiDataRiwayatPendidikanCreateHandler : INotificationHandler<DataPegawaiDataRiwayatPendidikanCreate>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataRiwayatPendidikanCreateHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataPegawaiDataRiwayatPendidikanCreate notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }
        }
    }
}
