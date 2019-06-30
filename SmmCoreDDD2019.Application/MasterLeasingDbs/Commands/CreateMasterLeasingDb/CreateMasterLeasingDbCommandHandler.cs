using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.CreateMasterLeasingDb
{
    public class CreateMasterLeasingDbCommandHandler : IRequestHandler<CreateMasterLeasingDbCommand, Unit>
    {

        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateMasterLeasingDbCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateMasterLeasingDbCommand request, CancellationToken cancellationToken)
        {
            var entity = new MasterLeasingDb
            {
                NamaLease= request.NamaLease,
               
            };

            _context.MasterLeasingDb.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new MasterLeasingDbCreated { MasterLeasingID = entity.Id.ToString() });

            return Unit.Value;
           
        }
    }
}
