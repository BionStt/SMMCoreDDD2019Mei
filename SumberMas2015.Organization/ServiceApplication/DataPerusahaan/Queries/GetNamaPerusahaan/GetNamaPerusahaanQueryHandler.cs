using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Organization.Dto.DataPerusahaan;
using SumberMas2015.Organization.InfrastructureData.Context;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaan.Queries.GetNamaPerusahaan
{
    public class GetNamaPerusahaanQueryHandler : IRequestHandler<GetNamaPerusahaanQuery, IReadOnlyCollection<GetNamaPerusahaanResponse>>
    {
        private readonly OrganizationContext _context;

        public GetNamaPerusahaanQueryHandler(OrganizationContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaPerusahaanResponse>> Handle(GetNamaPerusahaanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.DataPerusahaan.Select(x=>new GetNamaPerusahaanResponse { 
            
                IDPerusahaan = x.NoUrutId,
                NamaPerusahaan = x.NamaPerusahaan
            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
