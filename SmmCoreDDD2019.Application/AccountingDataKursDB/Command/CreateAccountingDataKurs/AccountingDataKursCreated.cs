using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.AccountingDataKursDB.Command.CreateAccountingDataKurs
{
    public class AccountingDataKursCreated : INotification
    {
        public string AccountingDataKursID { get; set; }
        public class AccountingDataKursCreatedHandler : INotificationHandler<AccountingDataKursCreated>
        {
            private readonly INotificationService _notification;

            public AccountingDataKursCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(AccountingDataKursCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
