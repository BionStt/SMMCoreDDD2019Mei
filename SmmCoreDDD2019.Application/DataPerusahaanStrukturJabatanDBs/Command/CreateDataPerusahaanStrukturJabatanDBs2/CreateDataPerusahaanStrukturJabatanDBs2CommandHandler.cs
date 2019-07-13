using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Command.CreateDataPerusahaanStrukturJabatanDBs2
{
    public class CreateDataPerusahaanStrukturJabatanDBs2CommandHandler : IRequestHandler<CreateDataPerusahaanStrukturJabatanDBs2Command, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPerusahaanStrukturJabatanDBs2CommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPerusahaanStrukturJabatanDBs2Command request, CancellationToken cancellationToken)
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
            var entity = new DataPerusahaanStrukturJabatan
            {
                KodeStruktur = request.KodeStruktur,
                NamaStrukturJabatan = request.NamaStrukturJabatan,
                Parent = NilaiParent


            };

            _context.DataPerusahaanStrukturJabatan.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPerusahaanStrukturJabatanDBs2Created { DataPerusahaanStrukturJabatanID = entity.Id.ToString() }, cancellationToken);

            return Unit.Value;
        }
    }
}
