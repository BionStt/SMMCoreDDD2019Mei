using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Commands.CreateDataPenjualanDetail
{
    public class CreateDataPenjualanDetailCommandHandler : IRequestHandler<CreateDataPenjualanDetailCommand, Guid>
    {
        private readonly SalesMarketingContext _context;
        private readonly InventoryContext _Inventorycontext;
        public CreateDataPenjualanDetailCommandHandler(SalesMarketingContext context, InventoryContext inventorycontext )
        {
            _context = context;
            _Inventorycontext=inventorycontext;
        }

        public async Task<Guid> Handle(CreateDataPenjualanDetailCommand request, CancellationToken cancellationToken)
        {
            var dtPenjualanId = await _context.DataPenjualan.Where(x=>x.NoUrutId== request.dataPenjualanId).Select(x=>x.DataPenjualanId).SingleOrDefaultAsync();
            var StokUnitId = await _Inventorycontext.StokUnit.Where(x => x.NoUrutId == request.stokUnitId).Select(x => x.StokUnitId).SingleOrDefaultAsync();


            var dtDataPenjualanDetail = Domain.DataPenjualanDetail.CreateDataPenjualanDetail(dtPenjualanId, StokUnitId, request.offTheRoad, request.bBN, request.hargaOTR, request.uangMuka,
                request.diskonKredit, request.diskonTunai, request.subsidi, request.promosi, request.komisi, request.joinPromo1, 
                request.joinPromo2, request.sPF, request.sellOut, request.dendaWilayah,request.UserNameId,request.UserName);


            await _context.DataPenjualanDetail.AddAsync(dtDataPenjualanDetail);
            await _context.SaveChangesAsync();

            return dtDataPenjualanDetail.DataPenjualanDetailId;
        }
    }
}
