using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Command.CreateDataPegawaiDataPribadiInput
{
    public class DataPegawaiDataPribadiInputCreated: INotification
    {
        public string DataPegawaiID { get; set; }
        public class DataPegawaiDataPribadiInputCreatedHandler : INotificationHandler<DataPegawaiDataPribadiInputCreated>
        {
            private readonly INotificationService _notification;

            public DataPegawaiDataPribadiInputCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
         
            public async Task Handle(DataPegawaiDataPribadiInputCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}

