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


namespace SmmCoreDDD2019.Application.CustomerDBs.Commands.UpdateCustomerDB
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateCustomerCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.CustomerDB
                .SingleAsync(c => c.CustomerID == request.CustomerID, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(CustomerDB), request.CustomerID);
            }
            entity.Email = request.Email;
            entity.Alamat = request.Alamat;
            entity.AlamatKirim = request.AlamatKirim;
            entity.Faks = request.Faks;
            entity.Handphone = request.Handphone;
            entity.Kecamatan = request.Kecamatan;
            entity.Kelurahan = request.Kelurahan;
            entity.Kota = request.Kota;
            entity.KodePos = request.KodePos;
            entity.Nama = request.Nama;
            entity.NamaBPKB = request.NamaBPKB;
            entity.NoKtp= request.NoKtp;
          entity.Telp = request.Telp;
            entity.TelpKantor = request.TelpKantor;
            entity.TglLahir = request.TglLahir ;
            entity.UserIDPeg = request.UserIDPeg;
            entity.UserInput= request.UserInput;
            

            _context.CustomerDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
