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

namespace SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.UpdateDataPegawaiDataKeluarga
{
    public class UpdateDataPegawaiDataKeluargaCommandHandler : IRequestHandler<UpdateDataPegawaiDataKeluargaCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiDataKeluargaCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(UpdateDataPegawaiDataKeluargaCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.DataPegawaiDataKeluarga
              .SingleAsync(c => c.DataPegawaiId == request.IDPegawai, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataKeluarga), request.IDPegawai);
            }

          //  entity.NoUrut = request.NoUrut;
            entity.DataPegawaiId = request.IDPegawai;
            entity.NamaK = request.NamaK;
            entity.AlamatK = request.AlamatK;
            entity.KelurahanK = request.KelurahanK;
            entity.KecamatanK = request.KecamatanK;
            entity.KotaK = request.KotaK;
            entity.KodePosK = request.KodePosK;
            entity.NoKtp = request.NoKtp;
            entity.HubunganK = request.HubunganK;

                entity.JenisKelamin = request.JenisKelamin;

                entity.TempatLahir = request.TempatLahir;
                entity.Tgllahir = request.Tgllahir;
                entity.PendidikanTerakhir = request.PendidikanTerakhir;
                entity.Agama = request.Agama;
                entity.Pekerjaan = request.Pekerjaan;
                entity.Keterangan = request.Keterangan;
                entity.EmergencyCall = request.EmergencyCall;
            entity.TglInput = request.TglInput;




            _context.DataPegawaiDataKeluarga.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
