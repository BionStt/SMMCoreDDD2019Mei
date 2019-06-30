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

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.UpdateMasterLeasingCabangDB
{
    public class UpdateMasterLeasingCabangDBCommandHandler : IRequestHandler<UpdateMasterLeasingCabangDBCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateMasterLeasingCabangDBCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateMasterLeasingCabangDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.MasterLeasingCabangDB
                .SingleAsync(c => c.Id == request.NoUrutLeasingCabang, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(MasterLeasingCabangDB), request.NoUrutLeasingCabang);
            }

            //entity.IDlease = request.IDlease;
            entity.Aktif = request.Aktif;
            entity.Alamat= request.Alamat;
            entity.Kelurahan= request.Kelurahan;
            entity.Kecamatan= request.Kecamatan;
            entity.Kota= request.Kota;
            entity.Propinsi = request.Propinsi;
            entity.KodePos= request.KodePos;
            entity.Cabang= request.Cabang;
            entity.Telp = request.Telp;
            entity.Faks= request.Faks;
            entity.Email = request.Email;


            _context.MasterLeasingCabangDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
