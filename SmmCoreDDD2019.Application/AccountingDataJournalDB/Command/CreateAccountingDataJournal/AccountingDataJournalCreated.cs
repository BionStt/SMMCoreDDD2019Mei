using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;

namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Command.CreateAccountingDataJournal
{
    public class AccountingDataJournalCreated : INotification
    {
        public string AccountingDataJournalID { get; set; }
        public class AccountingDataAccountCreatedHandler : INotificationHandler<AccountingDataJournalCreated>
        {
            private readonly INotificationService _notification;
            public AccountingDataAccountCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(AccountingDataJournalCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
                // throw new NotImplementedException();
            }
        }
    }
}
