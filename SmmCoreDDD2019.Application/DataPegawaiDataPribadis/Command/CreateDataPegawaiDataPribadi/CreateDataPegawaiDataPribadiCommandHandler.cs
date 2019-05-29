using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.CreateDataPegawaiDataPribadi
{
    public class CreateDataPegawaiDataPribadiCommandHandler : IRequestHandler<CreateDataPegawaiDataPribadiCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataPribadiCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPegawaiDataPribadiCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawaiDataPribadi
            {
               // NoUrut = request.NoUrut,
                IDPegawai = request.IDPegawai,
                NamaDepan = request.NamaDepan,
                NamaTengah = request.NamaTengah,
                NamaBelakang= request.NamaBelakang,
                AlamatRumah = request.AlamatRumah,
                KelurahanRumah = request.KelurahanRumah,
                KecamatanRumah= request.KecamatanRumah,
                KotaRumah = request.KotaRumah,
                KodePos= request.KodePos,
                AlamatKTP= request.AlamatKTP,
                KelurahanKTP = request.KelurahanKTP,
                KecamatanKTP= request.KecamatanKTP,
                KotaKTP= request.KotaKTP,
                KodePosKTP= request.KodePosKTP,
                NoKTP = request.NoKTP,
                Telp= request.Telp,
                Handphone= request.Handphone,
                Handphone2= request.Handphone2,
                Agama= request.Agama,
                TempatLahir= request.TempatLahir,
                TanggalLahir = request.TanggalLahir,
                JenisKelamin= request.JenisKelamin,
                StatusKawin= request.StatusKawin,
                GolonganDarah= request.GolonganDarah,
                StatusTempatTinggal= request.StatusTempatTinggal,
                Email= request.Email,
                TglInput= request.TglInput




            };

            _context.DataPegawaiDataPribadi.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

          await _mediator.Publish(new DataPegawaiDataPribadiCreated { DataPegawaiID = entity.NoUrut.ToString() },cancellationToken);

            return Unit.Value;



            // throw new NotImplementedException();
        }
    }
}
