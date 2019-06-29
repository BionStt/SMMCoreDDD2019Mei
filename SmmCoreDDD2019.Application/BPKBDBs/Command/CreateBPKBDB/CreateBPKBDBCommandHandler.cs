using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.BPKBDBs.Command.CreateBPKBDB
{
    public class CreateBPKBDBCommandHandler : IRequestHandler<CreateBPKBDBCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateBPKBDBCommandHandler(ISMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }

        public async Task<Unit> Handle(CreateBPKBDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new BPKBDB
            {
              PermohonanFakturDBId = request.NoUrutFaktur,
              NoBpkb = request.NoBpkb,
              TanggalTerimaBPKB = request.TanggalTerimaBPKB


            };

            _context.BPKBDB.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new BPKBDBCreated { BPKBID = entity.Id.ToString() });


            return Unit.Value;
        }
    }
}
