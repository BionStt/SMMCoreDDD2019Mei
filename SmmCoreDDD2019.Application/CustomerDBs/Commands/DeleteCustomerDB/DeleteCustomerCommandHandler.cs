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

namespace SmmCoreDDD2019.Application.CustomerDBs.Commands.DeleteCustomerDB
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteCustomerCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.CustomerDB
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(CustomerDB), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerID);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(CustomerDB), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.CustomerDB.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
