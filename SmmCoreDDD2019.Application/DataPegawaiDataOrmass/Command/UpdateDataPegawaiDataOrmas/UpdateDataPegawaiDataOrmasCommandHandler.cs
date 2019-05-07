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

namespace SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.UpdateDataPegawaiDataOrmas
{
    public class UpdateDataPegawaiDataOrmasCommandHandler : IRequestHandler<UpdateDataPegawaiDataOrmasCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiDataOrmasCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPegawaiDataOrmasCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataOrmas
                .SingleAsync(c => c.NoUrut == request.NoUrut, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataOrmas), request.IDPegawai);
            }

            entity.NoUrut = request.NoUrut;
            entity.IDPegawai = request.IDPegawai;
            entity.NamaOrmas = request.NamaOrmas;
            entity.AlamatOrmas = request.AlamatOrmas;
            entity.KotaOrmas = request.KotaOrmas;
            entity.TelpOrmas = request.TelpOrmas;
            entity.Jabatan = request.Jabatan;
            entity.JenisKegiatan = request.JenisKegiatan;
            entity.TglInput = request.TglInput;

            _context.DataPegawaiDataOrmas.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
