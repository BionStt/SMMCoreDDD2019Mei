using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.CreateMasterLeasingDb
{
    public class CreateMasterLeasingDbHandler : IRequestHandler<CreateMasterLeasingDbCommand, Unit>
    {

        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateMasterLeasingDbHandler(
            SMMCoreDDD2019DbContext context,
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

            await _mediator.Publish(new CreateMasterLeasingDbCreated { MasterLeasingID = entity.IDlease.ToString() });

            return Unit.Value;
           
        }
    }
}
