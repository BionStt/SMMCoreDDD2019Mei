using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.MasterBidangUsahaDBs
{
    public class GetNamaBidangUsahaQueryHandler : IRequestHandler<GetNamaBidangUsahaQuery, IReadOnlyCollection<GetNamaBidangUsahaResponse>>
    {
        private readonly SalesMarketingContext _context;
        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> Handle(GetNamaBidangUsahaQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangUsahaDB.Select(x => new GetNamaBidangUsahaResponse
            {
                NoKodeMasterBidangUsaha = x.MasterBidangUsahaDBId,
                NamaMasterBidangUsaha = x.NamaMasterBidangUsaha

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
