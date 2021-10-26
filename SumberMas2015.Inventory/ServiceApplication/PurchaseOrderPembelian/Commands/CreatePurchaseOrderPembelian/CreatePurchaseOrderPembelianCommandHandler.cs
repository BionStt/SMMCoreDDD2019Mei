using MediatR;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelian.Commands.CreatePurchaseOrderPembelian
{
    public class CreatePurchaseOrderPembelianCommandHandler : IRequestHandler<CreatePurchaseOrderPembelianCommand, Guid>
    {
        private readonly InventoryContext _context;

        public CreatePurchaseOrderPembelianCommandHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePurchaseOrderPembelianCommand request, CancellationToken cancellationToken)
        {
            var mstSupplierId = Guid.NewGuid();

            var dtPoPmb = Domain.PurchaseOrderPembelian.CreatePurchaseOrderPembelian(mstSupplierId, request.Keterangan, request.UserInput,request.PoASTRA);

            await _context.PurchaseOrderPembelian.AddAsync(dtPoPmb);
            await _context.SaveChangesAsync();

            return dtPoPmb.PurchaseOrderPembelianId;
        }
    }
}
