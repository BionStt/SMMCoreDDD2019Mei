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


namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.UpdateDataPerusahaanCabang
{
    public class UpdateDataPerusahaanCabangCommandHandler : IRequestHandler<UpdateDataPerusahaanCabangCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataPerusahaanCabangCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataPerusahaanCabangCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.DataPerusahaanCabang
               .SingleAsync(c => c.Id == request.KodePosisi, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPerusahaanCabang), request.KodePosisi);
            }

            entity.DataPerusahaanId = request.KodeP;
           // entity.KodePosisi = request.KodePosisi;
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
