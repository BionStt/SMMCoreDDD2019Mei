using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Commands.CreatePembelianDetail
{
    public class CreatePembelianDetailCommandHandler : IRequestHandler<CreatePembelianDetailCommand, Guid>
    {
        private readonly InventoryContext _context;

        public CreatePembelianDetailCommandHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePembelianDetailCommand request, CancellationToken cancellationToken)
        {
            var mstBarangId = await _context.MasterBarang.Where(x => x.NoUrutId==request.MasterBarangId).Select(x => x.MasterBarangId).SingleOrDefaultAsync();
            var PembelianId = await _context.Pembelian.Where(x => x.NoUrutId==request.PembelianId).Select(x => x.PembelianId).SingleOrDefaultAsync();

            var dtPembelianDetail = Domain.PembelianDetail.CreatePembelianDetail(mstBarangId,request.HargaOffTheRoad,request.BBN,
                request.Qty,request.Diskon,request.SellIn, PembelianId);

            await _context.PembelianDetail.AddAsync(dtPembelianDetail);
            await _context.SaveChangesAsync(cancellationToken);


            return dtPembelianDetail.PembelianDetailId;

        }
    }
}
