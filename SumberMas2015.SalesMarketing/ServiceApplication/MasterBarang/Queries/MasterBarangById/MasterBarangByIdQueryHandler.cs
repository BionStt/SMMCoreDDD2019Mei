using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.MasterBarang;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterBarang.Queries.MasterBarangById
{
    public class MasterBarangByIdQueryHandler : IRequestHandler<MasterBarangByIdQuery, MasterBarangByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public MasterBarangByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<MasterBarangByIdResponse> Handle(MasterBarangByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBarang.Where(x => x.NoUrutId == request.MasterBarangId).Select(x => new MasterBarangByIdResponse {
                NoUrutId=x.NoUrutId,
                MasterBarangIdGuid = x.MasterBarangId,
                NamaBarang = x.NamaBarang
            }).SingleOrDefaultAsync();
            return returnQuery;
        }
    }
}
