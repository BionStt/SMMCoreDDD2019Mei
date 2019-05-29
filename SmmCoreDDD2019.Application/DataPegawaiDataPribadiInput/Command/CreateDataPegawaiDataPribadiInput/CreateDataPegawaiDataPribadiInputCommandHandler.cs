using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Command.CreateDataPegawaiDataPribadiInput
{
    public class CreateDataPegawaiDataPribadiInputCommandHandler: IRequestHandler<CreateDataPegawaiDataPribadiInputCommand,Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataPribadiInputCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPegawaiDataPribadiInputCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawai
            {
               
             //   TglInput = request.TglInput,
                TglMulaiKerja = request.TglMulaiKerja,
                TglBerhentiKerja = request.TglBerhentiKerja,
                Aktif = request.Aktif,
            };
            _context.DataPegawai.Add(entity);
           await _context.SaveChangesAsync(cancellationToken);

            var entity2 = new DataPegawaiDataPribadi
            {
                // NoUrut = request.NoUrut,
                IDPegawai = entity.IDPegawai,
                NamaDepan = request.NamaDepan,
                NamaTengah = request.NamaTengah,
                NamaBelakang = request.NamaBelakang,
                AlamatRumah = request.AlamatRumah,
                KelurahanRumah = request.KelurahanRumah,
                KecamatanRumah = request.KecamatanRumah,
                KotaRumah = request.KotaRumah,
                PropinsiRumah=request.PropinsiRumah,
                KodePos = request.KodePos,
                AlamatKTP = request.AlamatKTP,
                KelurahanKTP = request.KelurahanKTP,
                KecamatanKTP = request.KecamatanKTP,
                KotaKTP = request.KotaKTP,
                PropinsiKTP = request.PropinsiKTP,
                KodePosKTP = request.KodePosKTP,
                NoKTP = request.NoKTP,
                Telp = request.Telp,
                Handphone = request.Handphone,
                Handphone2 = request.Handphone2,
                Agama = request.Agama,
                TempatLahir = request.TempatLahir,
                TanggalLahir = request.TanggalLahir,
                JenisKelamin = request.JenisKelamin,
                StatusKawin = request.StatusKawin,
                GolonganDarah = request.GolonganDarah,
                StatusTempatTinggal = request.StatusTempatTinggal,
                Email = request.Email
               // TglInput = request.TglInput

            };
                      
            _context.DataPegawaiDataPribadi.Add(entity2);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new DataPegawaiDataPribadiInputCreated { DataPegawaiID = entity.IDPegawai.ToString() },cancellationToken);
            return Unit.Value;

        }
    }
}
