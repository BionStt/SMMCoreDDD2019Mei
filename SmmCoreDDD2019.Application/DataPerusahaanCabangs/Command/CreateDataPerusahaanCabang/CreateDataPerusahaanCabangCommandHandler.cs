
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.CreateDataPerusahaanCabang
{
    public class CreateDataPerusahaanCabangCommandHandler : IRequestHandler<CreateDataPerusahaanCabangCommand, Unit>
    {

        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPerusahaanCabangCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }


        public async Task<Unit> Handle(CreateDataPerusahaanCabangCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPerusahaanCabang
            {
                KodeP = request.KodeP,
              //  KodePosisi = request.KodePosisi,
                NamaPosisi = request.NamaPosisi,
                Alamat= request.Alamat,
                Kel= request.Kel,
                Kec= request.Kec,
                Kota= request.Kota,
                Propinsi=request.Propinsi,
                KodePos= request.KodePos,
                Telp= request.Telp,
                Cp= request.Cp
            };

            _context.DataPerusahaanCabang.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPerusahaanCabangCreated { DataPerusahaanCabangID = entity.KodePosisi.ToString() });

            return Unit.Value;

            //  throw new NotImplementedException();
        }
    }
}
