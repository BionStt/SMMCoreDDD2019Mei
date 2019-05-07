using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Command.DeleteDataKontrakAngsuran
{
    public class DeleteDataKontrakAngsuranCommandHandler : IRequestHandler<DeleteDataKontrakAngsuranCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteDataKontrakAngsuranCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteDataKontrakAngsuranCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKontrakAngsuran
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKontrakAngsuran), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerID);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(CustomerDB), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataKontrakAngsuran.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
