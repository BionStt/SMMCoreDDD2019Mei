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

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Queries.ListCabangLeasing
{
    public class ListCabangLeasingQueryHandler : IRequestHandler<ListCabangLeasingQuery, IReadOnlyCollection<ListCabangLeasingResponse>>
    {
        private readonly SalesMarketingContext _context;

        public ListCabangLeasingQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<ListCabangLeasingResponse>> Handle(ListCabangLeasingQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.MasterLeasing
                                     join b in _context.MasterLeasingCabang on a.MasterLeasingId equals b.MasterLeasingId
                                     select new ListCabangLeasingResponse {
                                     NamaCab = a.NamaLeasing + " - "+ b.NamaCabang,
                                     NoUrutLeasingCabang = b.NoUrutId

                                     }).OrderBy(x=>x.NamaCab).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
