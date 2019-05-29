using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.DeleteDataKontrakKredit
{
    public class DeleteDataKontrakKreditCommandHandler : IRequestHandler<DeleteDataKontrakKreditCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public DeleteDataKontrakKreditCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteDataKontrakKreditCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKontrakKredit
              .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKontrakKredit), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerID);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(CustomerDB), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataKontrakKredit.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
