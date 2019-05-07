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

namespace SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.DeletePermohonanFaktur
{
    public class DeletePermohonanFakturCommandHandler : IRequestHandler<DeletePermohonanFakturCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeletePermohonanFakturCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeletePermohonanFakturCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.PermohonanFakturDB
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(PermohonanFakturDB), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerID);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(CustomerDB), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.PermohonanFakturDB.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
