using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.Notifications.Models;
using System.Threading;
namespace SmmCoreDDD2019.Application.AccountingTipeJournalDB.Command.CreateAccountingTipeJournal
{
    public class AccountingTipeJournalCreated : INotification
    {
        public string AccountingTipeJournalID { get; set; }
        public class AccountingTipeJournalCreatedHandler : INotificationHandler<AccountingTipeJournalCreated>
        {
            private readonly INotificationService _notification;

            public AccountingTipeJournalCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(AccountingTipeJournalCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
