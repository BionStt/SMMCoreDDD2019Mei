using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.CreateDataKontrakSurvei
{
    public class DataKontrakSurveiCreated : INotification
    {
        public string DataKontrakSurveiID { get; set; }

        public class DataKontrakSurveiCreatedHandler : INotificationHandler<DataKontrakSurveiCreated>
        {
            private readonly INotificationService _notification;

            public DataKontrakSurveiCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }
            public async Task Handle(DataKontrakSurveiCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                //  throw new NotImplementedException();
            }
        }
    }
}
