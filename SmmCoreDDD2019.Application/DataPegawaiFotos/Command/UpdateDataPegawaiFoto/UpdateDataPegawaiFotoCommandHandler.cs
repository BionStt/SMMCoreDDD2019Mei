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
namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.UpdateDataPegawaiFoto
{
    public class UpdateDataPegawaiFotoCommandHandler : IRequestHandler<UpdateDataPegawaiFotoCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPegawaiFotoCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPegawaiFotoCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiFoto
               .SingleAsync(c => c.IDPegawai == request.IDPegawai, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiFoto), request.IDPegawai);
            }

            entity.NoUrut = request.NoUrut;
            entity.Foto = request.Foto;
            entity.Tglinput= request.Tglinput;
            entity.Revisi= request.Revisi;
            entity.IDPegawai= request.IDPegawai;
            entity.KodeBarcode = request.KodeBarcode;
          

            _context.DataPegawaiFoto.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //throw new NotImplementedException();
        }
    }
}
