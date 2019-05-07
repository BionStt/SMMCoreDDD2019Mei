using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.DeleteDataSPKBaruDB
{
    public class DeleteDataSPKBaruDBCommandHandler : IRequestHandler<DeleteDataSPKBaruDBCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteDataSPKBaruDBCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteDataSPKBaruDBCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.DataSPKBaruDB
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataSPKBaruDB), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataSPKBaruDB.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
