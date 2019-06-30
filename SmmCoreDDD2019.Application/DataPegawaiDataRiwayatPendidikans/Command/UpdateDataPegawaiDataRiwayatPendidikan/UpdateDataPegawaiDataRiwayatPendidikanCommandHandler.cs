using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.UpdateDataPegawaiDataRiwayatPendidikan
{
    public class UpdateDataPegawaiDataRiwayatPendidikanCommandHandler : IRequestHandler<UpdateDataPegawaiDataRiwayatPendidikanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiDataRiwayatPendidikanCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPegawaiDataRiwayatPendidikanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataRiwayatPendidikan
               .SingleAsync(c => c.Id == request.NoUrut, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(CustomerDB), request.NoUrut);
            }

           // entity.NoUrut = request.NoUrut;
            entity.DataPegawaiId= request.IDPegawai;
            entity.TingkatPend= request.TingkatPend;
            entity.NamaSekolah= request.NamaSekolah;
            entity.Kota = request.Kota;
            entity.Jurusan= request.Jurusan;
            entity.TahunLulus = request.TahunLulus;
            entity.Keterangan = request.Keterangan;
         
            _context.DataPegawaiDataRiwayatPendidikan.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;


            //  throw new NotImplementedException();
        }
    }
}
