using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;


namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.UpdateDataPegawaiDataPribadi
{
    public class UpdateDataPegawaiDataPribadiCommandHandler : IRequestHandler<UpdateDataPegawaiDataPribadiCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiDataPribadiCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public  async Task<Unit> Handle(UpdateDataPegawaiDataPribadiCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataPribadi
               .SingleAsync(c => c.IDPegawai == request.IDPegawai, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataPribadi), request.IDPegawai);
            }


            entity.NoUrut = request.NoUrut;
            entity.IDPegawai = request.IDPegawai;
            entity.NamaDepan = request.NamaDepan;
            entity.NamaTengah = request.NamaTengah;
            entity.NamaBelakang = request.NamaBelakang;
            entity.AlamatRumah = request.AlamatRumah;
            entity.KelurahanRumah = request.KelurahanRumah;
            entity.KecamatanRumah = request.KecamatanRumah;
            entity.KotaRumah = request.KotaRumah;
            entity.KodePos = request.KodePos;
            entity.AlamatKTP = request.AlamatKTP;
            entity.KelurahanKTP = request.KelurahanKTP;
            entity.KecamatanKTP = request.KecamatanKTP;
            entity.KotaKTP = request.KotaKTP;
            entity.KodePosKTP = request.KodePosKTP;
            entity.NoKTP = request.NoKTP;
            entity.Telp = request.Telp;
            entity.Handphone = request.Handphone;
            entity.Handphone2 = request.Handphone2;
            entity.Agama = request.Agama;
            entity.TempatLahir = request.TempatLahir;
            entity.TanggalLahir = request.TanggalLahir;
            entity.JenisKelamin = request.JenisKelamin;
            entity.StatusKawin = request.StatusKawin;
            entity.GolonganDarah = request.GolonganDarah;
            entity.StatusTempatTinggal = request.StatusTempatTinggal;
            entity.Email = request.Email;
            entity.TglInput = request.TglInput;


            _context.DataPegawaiDataPribadi.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

           // throw new NotImplementedException();
        }
    }
}
