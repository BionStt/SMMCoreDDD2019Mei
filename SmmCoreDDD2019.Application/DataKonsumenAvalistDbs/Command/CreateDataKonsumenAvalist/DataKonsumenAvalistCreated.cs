using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.CreateDataKonsumenAvalist
{
    public class DataKonsumenAvalistCreated : INotification
    {
        public int DataKonsumenAvalistID { get; set; }
        public class DataKonsumenAvalistCreatedHandler : INotificationHandler<DataKonsumenAvalistCreated>
        {
            private readonly INotificationService _notification;

            public DataKonsumenAvalistCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DataKonsumenAvalistCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
