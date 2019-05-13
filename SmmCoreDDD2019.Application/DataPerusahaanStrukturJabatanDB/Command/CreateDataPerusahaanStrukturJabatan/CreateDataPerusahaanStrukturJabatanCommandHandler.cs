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
namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Command.CreateDataPerusahaanStrukturJabatan
{
    public class CreateDataPerusahaanStrukturJabatanCommandHandler : IRequestHandler<CreateDataPerusahaanStrukturJabatanCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPerusahaanStrukturJabatanCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateDataPerusahaanStrukturJabatanCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPerusahaanStrukturJabatan
            {
                KodeStruktur= request.KodeStruktur,
                NamaStrukturJabatan = request.NamaStrukturJabatan,
                Parent = request.Parent

            };

            _context.DataPerusahaanStrukturJabatan.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPerusahaanStrukturJabatanCreated { DataPerusahaanStrukturJabatanID = entity.NoUrutStrukturID.ToString() });

            return Unit.Value;
        }
    }
}
