using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.MasterLeasing;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Queries.ListLeasing
{
    public class ListLeasingQueryHandler : IRequestHandler<ListLeasingQuery, IReadOnlyCollection<ListLeasingResponse>>
    {
        private readonly SalesMarketingContext _context;

        public ListLeasingQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<ListLeasingResponse>> Handle(ListLeasingQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterLeasing.Select(x=>new ListLeasingResponse
            { 
                NoUrutId = x.NoUrutId,
                LeasingId=   x.MasterLeasingId,
                 NamaLeasing = x.NamaLeasing

            }).AsNoTracking().ToListAsync();

            return returnQuery; 
        }
    }
}
