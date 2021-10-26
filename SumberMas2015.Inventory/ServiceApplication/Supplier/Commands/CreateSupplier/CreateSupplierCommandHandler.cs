using MediatR;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.Supplier.Commands.CreateSupplier
{
    public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, Guid>
    {
        private readonly InventoryContext _context;

        public CreateSupplierCommandHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            var dtSupplier = Domain.Supplier.CreateSupplier(request.AlamatSupplier, request.NamaSupplier,request.Email);

            await _context.Supplier.AddAsync(dtSupplier);
            await _context.SaveChangesAsync();

            return dtSupplier.SupplierId;
        }
    }
}
