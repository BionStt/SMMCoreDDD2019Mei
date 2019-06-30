using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.CreateDataPegawaiFoto
{
    public class CreateDataPegawaiFotoCommandHandler : IRequestHandler<CreateDataPegawaiFotoCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiFotoCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPegawaiFotoCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawaiFoto
            {
               // NoUrut = request.NoUrut,
                Foto = request.Foto,
              //  Tglinput = request.Tglinput,
                Revisi= request.Revisi,
                DataPegawaiId= request.IDPegawai,
                KodeBarcode= request.KodeBarcode
              
            };

            _context.DataPegawaiFoto.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

           await _mediator.Publish(new DataPegawaiFotoCreated { DataPegawaiFotoID = entity.Id.ToString() });

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
