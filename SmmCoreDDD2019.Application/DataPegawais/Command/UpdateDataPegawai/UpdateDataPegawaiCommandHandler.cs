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

namespace SmmCoreDDD2019.Application.DataPegawais.Command.UpdateDataPegawai
{
    public class UpdateDataPegawaiCommandHandler : IRequestHandler<UpdateDataPegawaiCommand, Unit>
    {

        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPegawaiCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawai
                .SingleAsync(c => c.Id == request.IDPegawai, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawai), request.IDPegawai);
            }

            entity.Id = request.IDPegawai;
            entity.TglInput = request.TglInput;
            entity.TglMulaiKerja= request.TglMulaiKerja;
            entity.TglBerhentiKerja= request.TglBerhentiKerja;
            entity.Aktif= request.Aktif;
          

            _context.DataPegawai.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;



            // throw new NotImplementedException();
        }
    }
}
