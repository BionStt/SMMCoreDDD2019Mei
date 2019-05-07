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

namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.DeleteDataPegawaiFoto
{
   public class DeleteDataPegawaiFotoCommandHandler:IRequestHandler<DeleteDataPegawaiFotoCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteDataPegawaiFotoCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteDataPegawaiFotoCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiFoto
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiFoto), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataPegawaiFoto.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;


            // throw new NotImplementedException();
        }
    }
}
