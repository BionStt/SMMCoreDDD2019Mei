using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivotCabangLeasing
{
    public class GetLaporanPenjualanPivotCabangLeasingQueryHandler : IRequestHandler<GetLaporanPenjualanPivotCabangLeasingQuery, IReadOnlyCollection<GetLaporanPenjualanPivotCabangLeasingResponse>>
    {
        private readonly SalesMarketingContext _context;
        private readonly InventoryContext _inventoryContext;

        public GetLaporanPenjualanPivotCabangLeasingQueryHandler(SalesMarketingContext context, InventoryContext inventoryContext)
        {
            _context=context;
            _inventoryContext=inventoryContext;
        }

        public async Task<IReadOnlyCollection<GetLaporanPenjualanPivotCabangLeasingResponse>> Handle(GetLaporanPenjualanPivotCabangLeasingQuery request, CancellationToken cancellationToken)
        {
            var bb = await (from a in _context.DataPenjualanDetail
                            join b in _inventoryContext.StokUnit on a.StokUnitId equals b.StokUnitId
                            join c in _inventoryContext.MasterBarang on b.MasterBarangId equals c.MasterBarangId
                            join d in _context.DataPenjualan on a.DataPenjualanId equals d.DataPenjualanId
                            join e in _context.MasterLeasingCabang on d.MasterLeasingCabangId equals e.MasterLeasingCabangId
                            join f in _context.MasterLeasing on e.MasterLeasingId equals f.MasterLeasingId
                            where (d.TanggalPenjualan <= request.PeriodeAkhir && d.TanggalPenjualan >= request.PeriodeAwal)
                            select new
                            {
                                NamaLeasing = f.NamaLeasing,
                                CabangLeasing = e.NamaCabang,
                                Merek = c.Merek,
                                NoMesin = b.NomorMesin
                            }
                      ).ToListAsync(cancellationToken);

            var aa = (from a in bb
                      group a by new { a.NamaLeasing, a.CabangLeasing }
                           into BiongGroup
                      where BiongGroup.Count() > 0
                      select new GetLaporanPenjualanPivotCabangLeasingResponse
                      {
                          NamaLeasing = BiongGroup.Key.NamaLeasing,
                          CabangLeasing = BiongGroup.Key.CabangLeasing,
                          SUZUKI = BiongGroup.Where(a => a.Merek == "SUZUKI").Count(),
                          YAMAHA = BiongGroup.Where(a => a.Merek == "YAMAHA").Count(),
                          KAWASAKI = BiongGroup.Where(a => a.Merek == "KAWASAKI").Count(),
                          HONDA = BiongGroup.Where(a => a.Merek == "HONDA").Count(),
                          TtlRow = BiongGroup.Count()
                      }
            ).ToList();

            return aa;
        }
    }
}
