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


namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.DeleteDataPerusahaan
{
   public class DeleteDataPerusahaanCommandHandler:IRequestHandler<DeleteDataPerusahaanCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteDataPerusahaanCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteDataPerusahaanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPerusahaan
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPerusahaan), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataPerusahaan.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
