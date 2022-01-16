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

namespace SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Queries.GetDataSOByID
{
    public class GetDataSOByIDQueryHandler : IRequestHandler<GetDataSOByIDQuery, GetDataSOByIDResponse>
    {
        private readonly SalesMarketingContext _context;

        public GetDataSOByIDQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<GetDataSOByIDResponse> Handle(GetDataSOByIDQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.StokUnit
                                     join b in _context.MasterBarang on a.MasterBarangId equals b.MasterBarangId
                                     where a.NoUrutId == int.Parse(request.Id)
                                     select new GetDataSOByIDResponse
                                     {
                                         HargaOff = b.HargaOff,
                                         BBN = b.Bbn

                                     }).AsNoTracking().SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
