using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.DataSPK;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.GetNamaSPKPenjualan
{
    public class GetNamaSPKPenjualanQueryHandler : IRequestHandler<GetNamaSPKPenjualanQuery, IReadOnlyCollection<GetNamaSPKPenjualanResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaSPKPenjualanQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public  async Task<IReadOnlyCollection<GetNamaSPKPenjualanResponse>> Handle(GetNamaSPKPenjualanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataSPK
                                     join b in _context.DataSPKSurvei on a.DataSPKId equals b.DataSPKId
                                     join c in _context.DataSPKKendaraan on a.DataSPKId equals c.DataSPKId
                                     join d in _context.MasterBarang on c.MasterBarangId equals d.MasterBarangId
                                     join e in _context.DataSPKKredit on a.DataSPKId equals e.DataSPKId
                                  
                                     where a.StatusSPK == 0
                                     select new GetNamaSPKPenjualanResponse {
                                         NoUrutSPKBaru1= a.NoUrutId,
                                         NamaPemesan = string.Format("{0} - {1} - {2} - {3:c0}", b.NamaPemesan.NamaDepan, b.AlamatPemesan.NoHandphone, d.NamaBarang, e.DPPriceList)
                                     }


                ).AsNoTracking().ToListAsync();


               return returnQuery;
        }
    }
}
