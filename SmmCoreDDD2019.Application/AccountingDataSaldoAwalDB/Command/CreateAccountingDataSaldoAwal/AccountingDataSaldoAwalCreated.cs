using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.AccountingDataSaldoAwalDB.Command.CreateAccountingDataSaldoAwal
{
    public class AccountingDataSaldoAwalCreated : INotification
    {
        public string AccountingDataSaldoAwalID { get; set; }
        public class AccountingDataSaldoAwalCreatedHandler : INotificationHandler<AccountingDataSaldoAwalCreated>
        {
            private readonly INotificationService _notification;

            public AccountingDataSaldoAwalCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(AccountingDataSaldoAwalCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
