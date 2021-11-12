using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.Pembelian.Commands.CreatePembelian
{
    public class CreatePembelianCommandHandler : IRequestHandler<CreatePembelianCommand, Guid>
    {
        private readonly InventoryContext _context;

        public CreatePembelianCommandHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePembelianCommand request, CancellationToken cancellationToken)
        {
            //masih perlu diperbaiki
            var dtSupplier = await _context.Supplier.Where(x => x.NoUrutId==request.DataSupplierId).Select(x=>x.SupplierId).SingleOrDefaultAsync();
            var POId = await _context.PurchaseOrderPembelian.Where(x => x.NoUrutId==request.PurchaseOrderId).Select(x => x.PurchaseOrderPembelianId).SingleOrDefaultAsync();

            var dtPembelian = Domain.Pembelian.CreatePembelian(dtSupplier, request.JenisTransaksiPembelian,request.Tenor, request.Keterangan, request.UserNameInput, POId) ;

            await _context.Pembelian.AddAsync(dtPembelian);
            await _context.SaveChangesAsync();

            return dtPembelian.PembelianId;
        }
    }
}
