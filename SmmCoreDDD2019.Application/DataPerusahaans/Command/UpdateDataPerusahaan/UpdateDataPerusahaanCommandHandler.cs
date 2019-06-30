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

namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.UpdateDataPerusahaan
{
    public class UpdateDataPerusahaanCommandHandler : IRequestHandler<UpdateDataPerusahaanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPerusahaanCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPerusahaanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPerusahaan
               .SingleAsync(c => c.Id == request.KodeP, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPerusahaan), request.KodeP);
            }

          //  entity.KodeP = request.KodeP;
            entity.NamaP = request.NamaP;
            entity.AlamatP= request.AlamatP;
            entity.Kel= request.Kel;
            entity.Kec= request.Kec;
            entity.Kota= request.Kota;
            entity.KodePos= request.KodePos;
            entity.Telp= request.Telp;
            entity.Cs= request.Cs;

            _context.DataPerusahaan.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //throw new NotImplementedException();
        }
    }
}
