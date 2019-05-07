using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Command.CreateAccountingDataJournal
{
    public class CreateAccountingDataJournalCommandHandler : IRequestHandler<CreateAccountingDataJournalCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataJournalCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateAccountingDataJournalCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountingDataJournal
            {
                NoUrutJournalH = request.NoUrutJournalH,
                NoUrutAccountId = request.NoUrutAccountId,
                Debit= request.Debit,
                Kredit= request.Kredit,
                Keterangan= request.Keterangan


            };

            _context.AccountingDataJournal.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataJournalCreated { AccountingDataJournalID = entity.JournalID.ToString() });

            return Unit.Value;
        }
    }
}
