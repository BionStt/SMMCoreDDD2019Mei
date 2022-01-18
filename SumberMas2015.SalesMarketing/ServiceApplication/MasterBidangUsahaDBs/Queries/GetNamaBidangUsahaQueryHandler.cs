using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Blazor.Shared.Dto.MasterBidangUsaha;
//using SumberMas2015.SalesMarketing.Dto.MasterBidangUsahaDBs;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries
{
    public class GetNamaBidangUsahaQueryHandler : IRequestHandler<GetNamaBidangUsahaQuery, IReadOnlyCollection<GetNamaBidangUsahaResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaBidangUsahaQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> Handle(GetNamaBidangUsahaQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangUsahaDB.Select(x => new GetNamaBidangUsahaResponse
            {
                NoKodeMasterBidangUsaha = x.NoUrutId,
                NamaMasterBidangUsaha = x.NamaMasterBidangUsaha

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
