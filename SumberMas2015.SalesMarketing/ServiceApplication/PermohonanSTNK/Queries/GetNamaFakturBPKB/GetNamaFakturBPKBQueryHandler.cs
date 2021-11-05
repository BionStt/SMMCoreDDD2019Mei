using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.SalesMarketing.Dto.PermohonanSTNK;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Queries.GetNamaFakturBPKB
{
    public class GetNamaFakturBPKBQueryHandler : IRequestHandler<GetNamaFakturBPKBQuery, IReadOnlyCollection<GetNamaFakturBPKBResponse>>
    {
        private readonly SalesMarketingContext _context;
        private readonly InventoryContext _inventoryContext;

        public GetNamaFakturBPKBQueryHandler(SalesMarketingContext context, InventoryContext inventoryContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
        }

        public async Task<IReadOnlyCollection<GetNamaFakturBPKBResponse>> Handle(GetNamaFakturBPKBQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.PermohonanFaktur
                              join b in _context.DataPenjualanDetail on a.PenjualanDetailId equals b.DataPenjualanDetailId
                              join c in _context.DataPenjualan on b.DataPenjualanId equals c.DataPenjualanId
                              join d in _context.DataKonsumen on c.DataKonsumenId equals d.DataKonsumenId
                              join e in _inventoryContext.StokUnit on b.StokUnitId equals e.StokUnitId
                              join f in _inventoryContext.MasterBarang on e.MasterBarangId equals f.MasterBarangId
                              where _context.PermohonanBPKB.All(x => x.NoUrutId != a.NoUrutId)
                              select new GetNamaFakturBPKBResponse 
                              { NoUrutFaktur1 = a.NoUrutId, NamaFaktur = string.Format("{0} - {1} - {2}", e.NomorMesin, a.NamaFaktur, f.NamaBarang) }

            ).ToListAsync();


            return returnQuery;


        }
    }
}
