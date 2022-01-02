using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivotSales
{
    public class GetLaporanPenjualanPivotSalesQueryHandler : IRequestHandler<GetLaporanPenjualanPivotSalesQuery, IReadOnlyCollection<GetLaporanPenjualanPivotSalesResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetLaporanPenjualanPivotSalesQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetLaporanPenjualanPivotSalesResponse>> Handle(GetLaporanPenjualanPivotSalesQuery request, CancellationToken cancellationToken)
        {
            var bb = await (from a in _context.DataPenjualanDetail
                            join b in _context.StokUnit on a.StokUnitId equals b.StokUnitId
                            join c in _context.MasterBarang on b.MasterBarangId equals c.MasterBarangId
                            join d in _context.DataPenjualan on a.DataPenjualanId equals d.DataPenjualanId
                            join e in _context.MasterLeasingCabang on d.MasterLeasingCabangId equals e.MasterLeasingCabangId
                            join f in _context.MasterLeasing on e.MasterLeasingId equals f.MasterLeasingId
                            join g in _context.DataSalesMarketing on d.SalesUserId equals g.DataSalesMarketingId
                            where (d.TanggalPenjualan <= request.PeriodeAkhir && d.TanggalPenjualan >= request.PeriodeAwal) && (g.NoUrutId == Int32.Parse(request.NoUrutSales))
                            select new
                            {
                                NamaSales = g.NamaSales,
                                CabangLeasing = e.NamaCabang,
                                Merek = c.Merek,
                                NoMesin = b.NomorMesin
                            }
                      ).ToListAsync(cancellationToken);

            var aa = (from a in bb
                      group a by new { a.NamaSales }
                           into BiongGroup
                      where BiongGroup.Count() > 0
                      select new GetLaporanPenjualanPivotSalesResponse
                      {
                          NamaSales = BiongGroup.Key.NamaSales,
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
