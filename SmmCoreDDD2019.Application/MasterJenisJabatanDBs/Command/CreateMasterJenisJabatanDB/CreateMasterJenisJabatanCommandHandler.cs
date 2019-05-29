using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;

namespace SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Command.CreateMasterJenisJabatanDB
{
    public class CreateMasterJenisJabatanCommandHandler : IRequestHandler<CreateMasterJenisJabatanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateMasterJenisJabatanCommandHandler(ISMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateMasterJenisJabatanCommand request, CancellationToken cancellationToken)
        {
            var entity = new MasterJenisJabatan
            {
                NamaJabatan = request.NamaJabatan,
               

            };

            _context.MasterJenisJabatan.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new MasterJenisJabatanCreated { MasterJenisJabatanID = entity.NoUrut.ToString() },cancellationToken);
            return Unit.Value;

        }
    }
}
