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

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.DeleteDataPegawaiDataRiwayatPendidikan
{
    public class DeleteDataPegawaiDataRiwayatPendidikanCommandHandler : IRequestHandler<DeleteDataPegawaiDataRiwayatPendidikanCommand, Unit>
    {

        private readonly ISMMCoreDDD2019DbContext _context;

        public DeleteDataPegawaiDataRiwayatPendidikanCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteDataPegawaiDataRiwayatPendidikanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataRiwayatPendidikan
              .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataRiwayatPendidikan), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerID);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(CustomerDB), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataPegawaiDataRiwayatPendidikan.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            //  throw new NotImplementedException();
        }
    }
}
