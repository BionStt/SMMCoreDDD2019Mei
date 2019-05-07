using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.CreateDataPegawaiDataRiwayatPelatihan
{
    public class CreateDataPegawaiDataRiwayatPelatihanCommandHandler : IRequestHandler<CreateDataPegawaiDataRiwayatPelatihanCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataRiwayatPelatihanCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateDataPegawaiDataRiwayatPelatihanCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawaiDataRiwayatPelatihan
            {
              //  NoUrut = request.NoUrut,
                IDPegawai = request.IDPegawai,
                NamaLembaga= request.NamaLembaga,
                AlamatLembaga= request.AlamatLembaga,
                TelpLembaga= request.TelpLembaga,
                LamaKursus = request.LamaKursus,
                DibiayaiOleh= request.DibiayaiOleh,
                BidangPelatihan = request.BidangPelatihan
               


            };

            _context.DataPegawaiDataRiwayatPelatihan.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPegawaiDataRiwayatPelatihanCreated { DataPegawaiDataRiwayatPelatihanID = entity.NoUrut.ToString() });

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
