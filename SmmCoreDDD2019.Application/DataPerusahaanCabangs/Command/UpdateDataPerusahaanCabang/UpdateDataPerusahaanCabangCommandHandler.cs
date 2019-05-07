using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;


namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.UpdateDataPerusahaanCabang
{
    public class UpdateDataPerusahaanCabangCommandHandler : IRequestHandler<UpdateDataPerusahaanCabangCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataPerusahaanCabangCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPerusahaanCabangCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.DataPerusahaanCabang
               .SingleAsync(c => c.KodePosisi == request.KodePosisi, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPerusahaanCabang), request.KodePosisi);
            }

            entity.KodeP = request.KodeP;
            entity.KodePosisi = request.KodePosisi;
            entity.NamaPosisi = request.NamaPosisi;
            entity.Alamat= request.Alamat;
            entity.Kel= request.Kel;
            entity.Kec= request.Kec;
            entity.Kota = request.Kota;
            entity.KodePos= request.KodePos;
            entity.Telp= request.Telp;
            entity.Cp = request.Cp;

        _context.DataPerusahaanCabang.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
