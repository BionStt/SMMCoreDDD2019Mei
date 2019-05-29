using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.AccountingTipeJournalDB.Command.CreateAccountingTipeJournal
{
    public class CreateAccountingTipeJournalCommandHandler : IRequestHandler<CreateAccountingTipeJournalCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingTipeJournalCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateAccountingTipeJournalCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountingTipeJournal
            {
                //  KodeP = request.KodeP,
                NamaJournal = request.NamaJournal,
                KodeJournal = request.KodeJournal
               

            };

            _context.AccountingTipeJournal.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingTipeJournalCreated { AccountingTipeJournalID = entity.NoIDTipeJournal.ToString() });

            return Unit.Value;
        }
    }
}
