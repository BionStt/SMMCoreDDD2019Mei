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


namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.DeleteDataPegawaiDataJabatan
{
    public class DeleteDataPegawaiDataJabatanCommandHandler : IRequestHandler<DeleteDataPegawaiDataJabatanCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteDataPegawaiDataJabatanCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(DeleteDataPegawaiDataJabatanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataJabatan
              .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataJabatan), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataPegawaiDataJabatan.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //   throw new NotImplementedException();
        }
    }
}
