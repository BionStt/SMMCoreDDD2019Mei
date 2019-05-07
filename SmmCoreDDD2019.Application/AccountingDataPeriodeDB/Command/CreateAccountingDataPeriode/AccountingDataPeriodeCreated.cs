using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.AccountingDataPeriodeDB.Command.CreateAccountingDataPeriode
{
    public class AccountingDataPeriodeCreated : INotification
    {
        public string AccountingDataPeriodeID { get; set; }
        public class AccountingDataPeriodeCreatedHandler : INotificationHandler<AccountingDataPeriodeCreated>
        {
            private readonly INotificationService _notification;

            public AccountingDataPeriodeCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(AccountingDataPeriodeCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
