using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.CreateDataPegawaiDataRiwayatPekerjaan
{
    public class CreateDataPegawaiDataRiwayatPekerjaanCommandHandler : IRequestHandler<CreateDataPegawaiDataRiwayatPekerjaanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataRiwayatPekerjaanCommandHandler(

            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateDataPegawaiDataRiwayatPekerjaanCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawaiDataRiwayatPekerjaan
            {
                DataPegawaiId = request.IDPegawai,
                NamaPerusahaan= request.NamaPerusahaan,
                AlamatP = request.AlamatP,
                KelurahanP= request.KelurahanP,
                KecamatanP = request.KecamatanP,
                KotaP = request.KotaP,
               KodePosP= request.KodePosP,
                TelpP= request.TelpP,
                JabatanAwal= request.JabatanAwal,
                JabatanAkhir= request.JabatanAkhir,
                MulaiBekerja= request.MulaiBekerja,
                AkhirBekerja= request.AkhirBekerja,
                GajiTerakhir= request.GajiTerakhir ,
                AtasanP= request.AtasanP,
              //  TglInput= request.TglInput,
                Keterangan= request.Keterangan
              
            };

            _context.DataPegawaiDataRiwayatPekerjaan.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPegawaiDataRiwayatPekerjaanCreated { DatapegawaiDataRiwayatPekerjaanID = entity.Id.ToString() },cancellationToken);

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
