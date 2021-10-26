using MediatR;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelianDetail.Commands.CreatePurchaseOrderPembelianDetail
{
    public class CreatePurchaseOrderPembelianDetailCommandHandler : IRequestHandler<CreatePurchaseOrderPembelianDetailCommand, Guid>
    {
        private readonly InventoryContext _context;
        private IMediator _mediator;

        public CreatePurchaseOrderPembelianDetailCommandHandler(InventoryContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreatePurchaseOrderPembelianDetailCommand request, CancellationToken cancellationToken)
        {
            var mstBarang = Guid.NewGuid();

            var dtPoPmbDetail = Domain.PurchaseOrderPembelianDetail.CreatePurchaseOrderPembelianDetail(mstBarang, request.OffTHeRoad,
                request.BBN, request.Diskon, request.Warna, request.Qty, request.Keterangan);

            await _context.PurchaseOrderPembelianDetail.AddAsync(dtPoPmbDetail);
            await _context.SaveChangesAsync();

            return dtPoPmbDetail.PurchaseOrderPembelianDetailId;

        }
    }
}
