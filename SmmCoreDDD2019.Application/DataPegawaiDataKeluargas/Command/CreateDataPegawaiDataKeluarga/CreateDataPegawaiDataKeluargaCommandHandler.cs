using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.CreateDataPegawaiDataKeluarga
{
    public class CreateDataPegawaiDataKeluargaCommandHandler : IRequestHandler<CreateDataPegawaiDataKeluargaCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataKeluargaCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPegawaiDataKeluargaCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawaiDataKeluarga
            {
              //  NoUrut = request.NoUrut,
                DataPegawaiId= request.IDPegawai,
                NamaK= request.NamaK,
                AlamatK= request.AlamatK,
                KelurahanK= request.KelurahanK,
                KecamatanK = request.KecamatanK,
                KotaK = request.KotaK,
                KodePosK = request.KodePosK,
                NoKtp= request.NoKtp,
                HubunganK= request.HubunganK,
                JenisKelamin= request.JenisKelamin,
                TempatLahir= request.TempatLahir,
                Tgllahir= request.Tgllahir,
                PendidikanTerakhir= request.PendidikanTerakhir,
                Agama= request.Agama,
                Pekerjaan = request.Pekerjaan,
                Keterangan = request.Keterangan,
                EmergencyCall= request.EmergencyCall
              //  TglInput= request.TglInput
                


            };

            _context.DataPegawaiDataKeluarga.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPegawaiDataKeluargaCreated { DataPegawaiDataKeluargaID = entity.Id.ToString() },cancellationToken);

            return Unit.Value;

            //  throw new NotImplementedException();
        }
    }
}
