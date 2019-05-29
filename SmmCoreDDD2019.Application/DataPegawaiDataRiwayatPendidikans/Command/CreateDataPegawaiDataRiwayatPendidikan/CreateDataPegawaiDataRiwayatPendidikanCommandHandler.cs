using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.CreateDataPegawaiDataRiwayatPendidikan
{
    public class CreateDataPegawaiDataRiwayatPendidikanCommandHandler : IRequestHandler<CreateDataPegawaiDataRiwayatPendidikanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataRiwayatPendidikanCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }


        public async Task<Unit> Handle(CreateDataPegawaiDataRiwayatPendidikanCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawaiDataRiwayatPendidikan
            {
            //    NoUrut = request.NoUrut,
                IDPegawai= request.IDPegawai,
                TingkatPend = request.TingkatPend,
                NamaSekolah = request.NamaSekolah,
                Kota = request.Kota,
                Jurusan= request.Jurusan,
                TahunLulus  = request.TahunLulus,
                Keterangan = request.Keterangan
               
            };

            _context.DataPegawaiDataRiwayatPendidikan.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

           await _mediator.Publish(new DataPegawaiDataRiwayatPendidikanCreate { DataPegawaiDataRiwayatPendidikanID = entity.NoUrut.ToString() },cancellationToken);

            return Unit.Value;


            // throw new NotImplementedException();
        }
    }
}
