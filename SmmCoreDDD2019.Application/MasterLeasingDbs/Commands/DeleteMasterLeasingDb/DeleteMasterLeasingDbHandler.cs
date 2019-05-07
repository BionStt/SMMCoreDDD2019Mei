using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.DeleteMasterLeasingDb
{
    public class DeleteMasterLeasingDbHandler : IRequestHandler<DeleteMasterLeasingDbCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteMasterLeasingDbHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }



        public async Task<Unit> Handle(DeleteMasterLeasingDbCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.MasterLeasingDb
                .FindAsync(request.ID);

            if (entity == null)
            {
                throw new NotFoundException(nameof(MasterLeasingDb), request.ID);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.IDlease);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.MasterLeasingDb.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //   throw new NotImplementedException();
        }
    }
}
