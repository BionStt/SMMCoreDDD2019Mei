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

namespace SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Command.CreateAccountingDataJournalHeader
{
    public class CreateAccountingDataJournalHeaderCommandHandler : IRequestHandler<CreateAccountingDataJournalHeaderCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataJournalHeaderCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateAccountingDataJournalHeaderCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountingDataJournalHeader
            {
                AccountingDataPeriodeId = request.NoUrutPeriodeID,
                TanggalInput = request.TangglInput,
              //  NoBuktiJournal = request.NoBuktiJournal,
                Keterangan= request.Keterangan,
                AccountingTipeJournalId = request.NoIDTipeJournal,
                UserInput= request.UserInput

            };

            _context.AccountingDataJournalHeader.Add(entity);
            // DENGAN CANCELTOKEN MALAH GAK INPUT
            await _context.SaveChangesAsync(cancellationToken);
            int KodeIdHeader = entity.Id;
            int thn = entity.TanggalInput.Year;
            int bln = entity.TanggalInput.Month;
            string Isi1 = string.Empty;

            if (bln == 1) { Isi1 = "NBJ/" + KodeIdHeader + "/I/" + thn; }
            else if (bln == 2) { Isi1 = "NBJ/" + KodeIdHeader + "/II/" + thn; }
            else if (bln == 3) { Isi1 = "NBJ/" + KodeIdHeader + "/III/" + thn; }
            else if (bln == 4) { Isi1 = "NBJ/" + KodeIdHeader + "/IV/" + thn; }
            else if (bln == 5) { Isi1 = "NBJ/" + KodeIdHeader + "/V/" + thn; }
            else if (bln == 6) { Isi1 = "NBJ/" + KodeIdHeader + "/VI/" + thn; }
            else if (bln == 7) { Isi1 = "NBJ/" + KodeIdHeader + "/VII/" + thn; }
            else if (bln == 8) { Isi1 = "NBJ/" + KodeIdHeader + "/VIII/" + thn; }
            else if (bln == 9) { Isi1 = "NBJ/" + KodeIdHeader + "/IX/" + thn; }
            else if (bln == 10) { Isi1 = "NBJ/" + KodeIdHeader + "/X/" + thn; }
            else if (bln == 11) { Isi1 = "NBJ/" + KodeIdHeader + "/XI/" + thn; }
            else if (bln == 12) { Isi1 = "NBJ/" + KodeIdHeader + "/XII/" + thn; }

            var entity2 = await _context.AccountingDataJournalHeader.FindAsync(entity.Id);
            if (entity2 == null)
            {
                throw new NotFoundException(nameof(AccountingDataJournalHeader), entity.Id);
            }
            entity2.NoBuktiJournal = Isi1;
            _context.AccountingDataJournalHeader.Update(entity2);
            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataJournalHeaderCreated { AccountingDataJournalHeaderID = entity.Id.ToString() });

            return Unit.Value;
        }
    }
}
