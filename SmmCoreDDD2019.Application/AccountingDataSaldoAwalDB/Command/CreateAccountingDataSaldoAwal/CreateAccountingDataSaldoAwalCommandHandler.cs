using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.AccountingDataSaldoAwalDB.Command.CreateAccountingDataSaldoAwal
{
    public class CreateAccountingDataSaldoAwalCommandHandler : IRequestHandler<CreateAccountingDataSaldoAwalCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataSaldoAwalCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateAccountingDataSaldoAwalCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountingDataSaldoAwal
            {
                //  KodeP = request.KodeP,
                NoUrutPeriodeID = request.NoUrutPeriodeID,
                NoUrutAccountId = request.NoUrutAccountId,
                Debet = request.Debet,
                Kredit= request.Kredit,
                Saldo = request.Saldo,
                MataUangID = request.MataUangID,
                UserInput = request.UserInput,
                NilaiKurs = request.NilaiKurs,
                TanggalInput = request.TanggalInput
              


            };

            _context.AccountingDataSaldoAwal.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataSaldoAwalCreated { AccountingDataSaldoAwalID = entity.NoUrutSaldoAwalID.ToString() });

            return Unit.Value;
        }
    }
}
