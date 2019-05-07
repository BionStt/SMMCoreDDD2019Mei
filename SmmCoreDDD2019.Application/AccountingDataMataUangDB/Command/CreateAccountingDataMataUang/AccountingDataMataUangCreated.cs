using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.AccountingDataMataUangDB.Command.CreateAccountingDataMataUang
{
    public class AccountingDataMataUangCreated : INotification
    {
        public string AccountingDataMataUangID { get; set; }
        public class AccountingDataMataUangCreatedHandler : INotificationHandler<AccountingDataMataUangCreated>
        {
            private readonly INotificationService _notification;

            public AccountingDataMataUangCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(AccountingDataMataUangCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
