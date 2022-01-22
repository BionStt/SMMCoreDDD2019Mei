using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.StokUnit;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Queries.GetDataSO
{
    public class GetDataSOQueryHandler : IRequestHandler<GetDataSOQuery, IReadOnlyCollection<GetDataSOResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetDataSOQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetDataSOResponse>> Handle(GetDataSOQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.StokUnit
                                     join b in _context.MasterBarang on a.MasterBarangId equals b.MasterBarangId
                                     where a.Terjual==null
                                     select new GetDataSOResponse
                                     {
                                         NoUrutSO = a.NoUrutId,
                                         NamaBarang = string.Format("{0} - {1} - {2} - {3} - {4} - {5:c}", a.NomorMesin, a.NomorRangka, a.Warna, b.NamaBarang, b.Merek, b.HargaOff + b.Bbn)


                                     }
                                     ).AsNoTracking().ToListAsync();

            
            return returnQuery;
        }
    }
}
