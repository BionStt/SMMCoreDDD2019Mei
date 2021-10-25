using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.JenisKelamin;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.JenisKelamin.ListJenisKelaminById
{
    public class ListJenisKelaminByIdQueryHandler : IRequestHandler<ListJenisKelaminByIdQuery, ListJenisKelaminByIdResponse>
    {
        private readonly SalesMarketingContext _context;

        public ListJenisKelaminByIdQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<ListJenisKelaminByIdResponse> Handle(ListJenisKelaminByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.JenisKelamin.Where(x => x.NoUrutId == request.NoUrutId).Select(x => new ListJenisKelaminByIdResponse {
                NoUrutId = x.NoUrutId,
                JenisKelaminKeterangan = x.JenisKelaminKeterangan,
                ListJenisKelaminResponseId = x.JenisKelaminId

            }).SingleOrDefaultAsync();

            return returnQuery;

        }
    }
}
