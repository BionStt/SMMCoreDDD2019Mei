using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Command.CreateAccountingDataAccount
{
    public class CreateAccountingDataAccountCommandHandler : IRequestHandler<CreateAccountingDataAccountCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataAccountCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateAccountingDataAccountCommand request, CancellationToken cancellationToken)
        {
            string NilaiParent;
            if (request.Parent == "0")
            {
                NilaiParent = null;
            }
            else
            {
                NilaiParent = request.Parent;

            };

            var entity = new AccountingDataAccount
            {
                KodeAccount = request.KodeAccount,
                Account = request.Account,
                NormalPos = request.NormalPos,
                Kelompok = request.Kelompok,
                MataUangID= request.MataUangID,
              //  Parent = request.Parent
              Parent= NilaiParent
            };

            _context.AccountingDataAccount.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataAccountCreated { AccountingDataAccountID = entity.NoUrutAccountId.ToString() });

            return Unit.Value;
        }
    }
}
