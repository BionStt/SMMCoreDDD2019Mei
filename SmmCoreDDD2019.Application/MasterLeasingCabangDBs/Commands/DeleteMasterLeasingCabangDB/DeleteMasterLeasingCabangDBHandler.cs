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

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.DeleteMasterLeasingCabangDB
{
    public class DeleteMasterLeasingCabangDBHandler : IRequestHandler<DeleteMasterLeasingCabangDBCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteMasterLeasingCabangDBHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteMasterLeasingCabangDBCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.MasterLeasingCabangDB
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(MasterLeasingCabangDB), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.IDlease);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.MasterLeasingCabangDB.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            //throw new NotImplementedException();
        }
    }
}
