using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.PermohonanSTNK;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Queries.GetNamaFakturStnk
{
    public class GetNamaFakturStnkQueryHandler : IRequestHandler<GetNamaFakturStnkQuery, IReadOnlyCollection<GetNamaFakturStnkResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaFakturStnkQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetNamaFakturStnkResponse>> Handle(GetNamaFakturStnkQuery request, CancellationToken cancellationToken)
        {
            // perlu dianalisa context lintas 
            var returnQuery = await ( from a in _context.PermohonanFaktur
                                      join b in _context.DataPenjualanDetail on a.PenjualanDetailId equals b.DataPenjualanDetailId
                                      join c in _context.DataPenjualan on b.DataPenjualanId equals c.DataPenjualanId
                                      join d in _context.DataKonsumen on c.DataKonsumenId equals d.DataKonsumenId
                                      join e in _context.StokUnit on b.StokUnitId equals e.StokUnitId
                                      join f in _context.MasterBarang on e.MasterBarangId equals f.MasterBarangId
                                      where _context.PermohonanSTNK.All(x=>x.PermohonanFakturDBId != a.NoUrutId)
                                      select new GetNamaFakturStnkResponse {
                                          NoUrutFaktur1 = a.NoUrutId,
                                          NamaFaktur = string.Format("{0} - {1} - {2}", e.NomorMesin, a.NamaFaktur, f.NamaBarang)
                                      
                                      }).ToListAsync();


            return returnQuery;
        }
    }
}
