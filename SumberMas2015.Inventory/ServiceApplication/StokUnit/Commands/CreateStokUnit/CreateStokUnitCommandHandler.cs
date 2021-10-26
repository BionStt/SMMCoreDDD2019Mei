using MediatR;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.CreateStokUnit
{
    public class CreateStokUnitCommandHandler : IRequestHandler<CreateStokUnitCommand, Guid>
    {
        private readonly InventoryContext _context;

        public CreateStokUnitCommandHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateStokUnitCommand request, CancellationToken cancellationToken)
        {
            var pembelianDetailId = Guid.NewGuid();
            var masterBarangId = Guid.NewGuid();

            var dtStokUnit = Domain.StokUnit.CreateStokUnit(pembelianDetailId, masterBarangId, request.NomorRangka, request.NomorMesin,
                request.Warna, request.Harga, request.Diskon, request.Sellin, request.Harga1, request.Diskon2, request.SellIn2, request.HargaPPN, request.DiskonPPN, request.SellInPPN);

            await _context.StokUnit.AddAsync(dtStokUnit);
            await _context.SaveChangesAsync();

            return dtStokUnit.StokUnitId;
        }
    }
}
