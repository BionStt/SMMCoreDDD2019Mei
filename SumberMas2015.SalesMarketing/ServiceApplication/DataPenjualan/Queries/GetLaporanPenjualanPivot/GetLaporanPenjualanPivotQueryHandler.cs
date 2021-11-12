using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivot
{
    public class GetLaporanPenjualanPivotQueryHandler : IRequestHandler<GetLaporanPenjualanPivotQuery, IReadOnlyCollection<GetLaporanPenjualanPivotResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetLaporanPenjualanPivotQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetLaporanPenjualanPivotResponse>> Handle(GetLaporanPenjualanPivotQuery request, CancellationToken cancellationToken)
        {
            var bb = await (from a in _context.DataPenjualanDetail
                            join b in _context.StokUnit on a.StokUnitId equals b.StokUnitId
                            join c in _context.MasterBarang on b.MasterBarangId equals c.MasterBarangId
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

            var aa =  (from a in bb
                      group a by new { a.NamaLeasing }
                           into BiongGroup
                      where BiongGroup.Count() > 0
                      select new GetLaporanPenjualanPivotResponse
                      {
                          NamaLeasing = BiongGroup.Key.NamaLeasing,
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
