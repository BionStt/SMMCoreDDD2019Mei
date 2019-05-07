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
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.UpdateDataPegawaiDataJabatan
{
    public class UpdateDataPegawaiDataJabatanCommandHandler : IRequestHandler<UpdateDataPegawaiDataJabatanCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiDataJabatanCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataPegawaiDataJabatanCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.DataPegawaiDataJabatan
              .SingleAsync(c => c.IDPegawai == request.IDPegawai, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataJabatan), request.IDPegawai);
            }

            entity.NoUrut = request.NoUrut;
                entity.IDPegawai = request.IDPegawai;
                entity.NoUrutJabatan = request.NoUrutJabatan;
                entity.TglMenjabat = request.TglMenjabat;
                entity.TglBerhentiMenjabat = request.TglBerhentiMenjabat;
                entity.Keterangan = request.Keterangan;


            _context.DataPegawaiDataJabatan.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;



            // throw new NotImplementedException();
        }
    }
}
