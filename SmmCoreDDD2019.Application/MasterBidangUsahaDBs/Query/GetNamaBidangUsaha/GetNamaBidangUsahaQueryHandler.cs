using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;
using SmmCoreDDD2019.Application.Dto.MasterBidangUsahaDBs;

namespace SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha
{
    public class GetNamaBidangUsahaQueryHandler : IRequestHandler<GetNamaBidangUsahaQuery, IReadOnlyCollection<GetNamaBidangUsahaResponse>>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public GetNamaBidangUsahaQueryHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> Handle(GetNamaBidangUsahaQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangUsahaDB.Select(x=> new GetNamaBidangUsahaResponse {
                NoKodeMasterBidangUsaha = x.Id,
                NamaMasterBidangUsaha = x.NamaMasterBidangUsaha

            } ).AsNoTracking().ToListAsync();

            return returnQuery;

        }
    }
}
