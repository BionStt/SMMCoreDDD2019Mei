using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.SalesMarketing;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.SalesMarketing.Queries.GetNamaSalesForce
{
    public class GetNamaSalesForceQueryHandler : IRequestHandler<GetNamaSalesForceQuery, IReadOnlyCollection<GetNamaSalesForceResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaSalesForceQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetNamaSalesForceResponse>> Handle(GetNamaSalesForceQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.DataSalesMarketing.Select(x=> new GetNamaSalesForceResponse {
            NoUrutId= x.NoUrutId,
            NamasalesForce = x.NamaSales
            }).ToListAsync();


            return returnQuery;

        }
    }
}
