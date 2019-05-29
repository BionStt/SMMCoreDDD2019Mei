using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;


namespace SmmCoreDDD2019.Application.MasterBarangDBs.Commands.DeleteMasterBarangDBs
{
    public class DeleteMasterBarangDBCommandHandler : IRequestHandler<DeleteMasterBarangDBCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public DeleteMasterBarangDBCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async  Task<Unit> Handle(DeleteMasterBarangDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.MasterBarangDB.FindAsync(request.Id);
            if (entity== null)
            {
                throw new NotFoundException(nameof(MasterBarangDB), request.Id);
            }

            //var hasOrders = _context.OrderDetails.Any(od => od.ProductId == entity.ProductId);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Product), request.Id, "There are existing orders associated with this product.");
            //}

            _context.MasterBarangDB.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
            //throw new NotImplementedException();
        }
    }
}
