using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.ServiceApplication.Penjualan.Queries.GetNamaPenjualanFaktur
{
    public class GetNamaPenjualanFakturQueryHandler : IRequestHandler<GetNamaPenjualanFakturQuery, IReadOnlyCollection<GetNamaPenjualanFakturResponse>>
    {
        private readonly SalesMarketingContext _context;
        private readonly InventoryContext _inventoryContext;

        public GetNamaPenjualanFakturQueryHandler(SalesMarketingContext context, InventoryContext inventoryContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
        }

        public async Task<IReadOnlyCollection<GetNamaPenjualanFakturResponse>> Handle(GetNamaPenjualanFakturQuery request, CancellationToken cancellationToken)
        {
            // perlu dianalisa kembali. apakah perlu read model tersendiri jangan lintas context ambil data.

            var returnQuery = await (from a in _context.DataPenjualan
                                     join b in _context.DataPenjualanDetail on a.DataPenjualanId equals b.DataPenjualanId
                                     join c in _context.DataKonsumen on a.DataKonsumenId equals c.DataKonsumenId
                                     join d in _inventoryContext.StokUnit on b.StokUnitId equals d.StokUnitId
                                     join e in _inventoryContext.MasterBarang on d.MasterBarangId equals e.MasterBarangId
                                     where _context.PermohonanFaktur.All(x=>x.PenjualanDetailId == b.DataPenjualanDetailId)
                                     select new GetNamaPenjualanFakturResponse {
                                         NoPenjualanDetail = b.NoUrutId,
                                         NamaKonsumen1 = string.Format("{0} - {1} - {2} - {3}", d.NomorMesin, c.Nama, c.NamaBPKB, e.NamaBarang)
                                     }).ToListAsync();

            return returnQuery;
        }
    }
}
