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

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetNamaPenjualanFaktur
{
    public class GetNamaPenjualanFakturQueryHandler : IRequestHandler<GetNamaPenjualanFakturQuery, IReadOnlyCollection<GetNamaPenjualanFakturResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaPenjualanFakturQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetNamaPenjualanFakturResponse>> Handle(GetNamaPenjualanFakturQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataPenjualan
                                     join b in _context.DataPenjualanDetail on a.DataPenjualanId equals b.DataPenjualanId
                                     join c in _context.DataKonsumen on a.DataKonsumenId equals c.DataKonsumenId
                                     join d in _context.StokUnit on b.StokUnitId equals d.StokUnitId
                                     join e in _context.MasterBarang on d.MasterBarangId equals e.MasterBarangId
                                     where _context.PermohonanFaktur.All(x => x.PenjualanDetailId!=b.DataPenjualanDetailId)

                                     //   where a.Terinput == null
                                     select new GetNamaPenjualanFakturResponse
                                     { NoPenjualanDetail = b.NoUrutId, 
                                       NamaKonsumen1 = string.Format("{0} - {1} - {2} - {3}", d.NomorMesin, c.Nama, c.NamaBPKB, e.NamaBarang) 
                                     }).ToListAsync();

            return returnQuery;
        }
    }
}
