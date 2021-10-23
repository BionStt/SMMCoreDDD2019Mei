using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.MasterBidangPekerjaanDBs;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries
{
    public class GetNamaBidangPekerjaanQueryHandler : IRequestHandler<GetNamaBidangPekerjaanQuery, IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>
    {
        private readonly SalesMarketingContext _dbcontext;

        public GetNamaBidangPekerjaanQueryHandler(SalesMarketingContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>> Handle(GetNamaBidangPekerjaanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbcontext.MasterBidangPekerjaanDB.Select(x => new GetNamaBidangPekerjaanResponse
            {
                NoUrutBidangPekerjaan = x.NoUrutId,
                NamaMasterBidangPekerjaan = x.NamaMasterBidangPekerjaan

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
