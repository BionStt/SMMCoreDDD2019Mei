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

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.UpdateMasterLeasingDb
{
    public class UpdateMasterLeasingDbCommandHandler : IRequestHandler<UpdateMasterLeasingDbCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateMasterLeasingDbCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }



        public async Task<Unit> Handle(UpdateMasterLeasingDbCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.MasterLeasingDb
               .SingleAsync(c => c.Id == request.IDlease, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(MasterLeasingDb), request.IDlease);
            }

            entity.NamaLease = request.NamaLease;
           
            _context.MasterLeasingDb.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //throw new NotImplementedException();
        }
    }
}
