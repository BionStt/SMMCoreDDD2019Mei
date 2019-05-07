using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.AccountingDataKursDB.Command.CreateAccountingDataKurs
{
    public class CreateAccountingDataKursCommandHandler : IRequestHandler<CreateAccountingDataKursCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataKursCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateAccountingDataKursCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountingDataKurs
            {
                //  KodeP = request.KodeP,
                MataUangID = request.MataUangID,
                TanggalInput = request.TanggalInput,
                Nilai = request.Nilai


            };

            _context.AccountingDataKurs.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataKursCreated { AccountingDataKursID = entity.NoUrutKursID.ToString() });

            return Unit.Value;
        }
    }
}
