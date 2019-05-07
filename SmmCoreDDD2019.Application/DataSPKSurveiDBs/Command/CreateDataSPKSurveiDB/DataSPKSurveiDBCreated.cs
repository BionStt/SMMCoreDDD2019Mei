using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.CreateDataSPKSurveiDB
{
    public class DataSPKSurveiDBCreated:INotification
    {
        public string DataSPKSurveiDCID { get; set; }
        public class DataSPKSurveiDBCreatedHandler : INotificationHandler<DataSPKSurveiDBCreated>
        {

            private readonly INotificationService _notification;

            public DataSPKSurveiDBCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataSPKSurveiDBCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());

                // throw new NotImplementedException();
            }
        }
    }
}
