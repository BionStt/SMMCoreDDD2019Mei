using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.AccountingDataPeriodeDB.Command.CreateAccountingDataPeriode
{
    public class CreateAccountingDataPeriodeCommandHandler : IRequestHandler<CreateAccountingDataPeriodeCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataPeriodeCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateAccountingDataPeriodeCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountingDataPeriode
            {
                //  KodeP = request.KodeP,
                Mulai = request.Mulai,
                Berakhir= request.Berakhir,
                IsAktif = request.IsAktif,
                UserInput = request.UserInput

            };

            _context.AccountingDataPeriode.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataPeriodeCreated { AccountingDataPeriodeID = entity.Id.ToString() });

            return Unit.Value;
        }
    }
}
