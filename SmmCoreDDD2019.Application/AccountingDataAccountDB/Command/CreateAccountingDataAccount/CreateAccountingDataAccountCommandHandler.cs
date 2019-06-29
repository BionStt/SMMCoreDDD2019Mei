using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Command.CreateAccountingDataAccount
{
    public class CreateAccountingDataAccountCommandHandler : IRequestHandler<CreateAccountingDataAccountCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateAccountingDataAccountCommandHandler(
            ISMMCoreDDD2019DbContext context,
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
                AccountingDataMataUangId= request.AccountingDataMataUangId,
              //  Parent = request.Parent
              Parent= NilaiParent
            };

            _context.AccountingDataAccount.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new AccountingDataAccountCreated { AccountingDataAccountID = entity.Id.ToString() });

            return Unit.Value;
        }
    }
}
