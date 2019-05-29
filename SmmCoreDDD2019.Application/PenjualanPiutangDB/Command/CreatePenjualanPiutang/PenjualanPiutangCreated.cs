﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
namespace SmmCoreDDD2019.Application.PenjualanPiutangDB.Command.CreatePenjualanPiutang
{
    public class PenjualanPiutangCreated : INotification
    {
        public string PenjualanPiutangID { get; set; }
        public class PenjualanPiutangCreatedHandler : INotificationHandler<PenjualanPiutangCreated>
        {
            private readonly INotificationService _notification;
            public PenjualanPiutangCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(PenjualanPiutangCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }


    }
}