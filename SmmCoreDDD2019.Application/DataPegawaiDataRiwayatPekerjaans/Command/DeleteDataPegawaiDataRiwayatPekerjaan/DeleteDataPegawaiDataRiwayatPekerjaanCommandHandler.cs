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
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.DeleteDataPegawaiDataRiwayatPekerjaan
{
    public class DeleteDataPegawaiDataRiwayatPekerjaanCommandHandler : IRequestHandler<DeleteDataPegawaiDataRiwayatPekerjaanCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public DeleteDataPegawaiDataRiwayatPekerjaanCommandHandler(SMMCoreDDD2019DbContext context)
        {

            _context = context;
        }
        public async Task<Unit> Handle(DeleteDataPegawaiDataRiwayatPekerjaanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataPegawaiDataRiwayatPekerjaan
              .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataPegawaiDataRiwayatPekerjaan), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataPegawaiDataRiwayatPekerjaan.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;


            //  throw new NotImplementedException();
        }
    }
}
