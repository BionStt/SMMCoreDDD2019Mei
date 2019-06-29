using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.AccountingDataMataUangDB.Command.CreateAccountingDataMataUang
{
    public class CreateAccountingDataMataUangCommandHandler : IRequestHandler<CreateAccountingDataMataUangCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataMataUangCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateAccountingDataMataUangCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountingDataMataUang
            {
                //  KodeP = request.KodeP,
              Kode=request.Kode,
              Nama = request.Nama

            };

            _context.AccountingDataMataUang.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataMataUangCreated { AccountingDataMataUangID = entity.Id.ToString() });

            return Unit.Value;

        }
    }
}
