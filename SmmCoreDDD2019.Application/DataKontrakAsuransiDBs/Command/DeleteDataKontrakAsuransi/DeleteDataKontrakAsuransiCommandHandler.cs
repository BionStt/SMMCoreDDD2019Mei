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
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.DeleteDataKontrakAsuransi
{
    public class DeleteDataKontrakAsuransiCommandHandler : IRequestHandler<DeleteDataKontrakAsuransiCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public DeleteDataKontrakAsuransiCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteDataKontrakAsuransiCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKontrakAsuransi
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKontrakAsuransi), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerID);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(CustomerDB), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataKontrakAsuransi.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
