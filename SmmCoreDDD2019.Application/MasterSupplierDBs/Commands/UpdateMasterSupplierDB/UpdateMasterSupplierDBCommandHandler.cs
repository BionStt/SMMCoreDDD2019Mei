using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.UpdateMasterSupplierDB
{
    public class UpdateMasterSupplierDBCommandHandler : IRequestHandler<UpdateMasterSupplierDBCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        public UpdateMasterSupplierDBCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateMasterSupplierDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.MasterSupplierDB
               .SingleAsync(c => c.IDSupplier == request.IDSupplier, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(MasterSupplierDB), request.IDSupplier);
            }

            entity.Aktif = request.Aktif;
            entity.Alamat= request.Alamat;
            entity.Kelurahan= request.Kelurahan;
            entity.Kecamatan= request.Kecamatan;
            entity.Kota= request.Kota;
            entity.Propinsi= request.Propinsi;
            entity.KodePos= request.KodePos;
            entity.NamaSupplier= request.NamaSupplier;
            entity.Telp= request.Telp;
            entity.Faks = request.Faks;
            entity.Email= request.Email;

            _context.MasterSupplierDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //  throw new NotImplementedException();
        }
    }
}
