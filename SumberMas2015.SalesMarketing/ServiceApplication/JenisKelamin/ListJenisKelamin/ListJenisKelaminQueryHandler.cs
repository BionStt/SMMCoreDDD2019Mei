using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Blazor.Shared.Dto.JenisKelamin;
//using SumberMas2015.SalesMarketing.Dto.JenisKelamin;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.JenisKelamin.ListJenisKelamin
{
    public class ListJenisKelaminQueryHandler : IRequestHandler<ListJenisKelaminQuery, IReadOnlyCollection<ListJenisKelaminResponse>>
    {
        private readonly SalesMarketingContext _context;

        public ListJenisKelaminQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<ListJenisKelaminResponse>> Handle(ListJenisKelaminQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.JenisKelamin.Select(x => new ListJenisKelaminResponse
            {
                NoUrutId = x.NoUrutId,
                JenisKelaminKeterangan  = x.JenisKelaminKeterangan
            }).AsNoTracking().ToListAsync();

            return returnQuery;

        }
    }
}
