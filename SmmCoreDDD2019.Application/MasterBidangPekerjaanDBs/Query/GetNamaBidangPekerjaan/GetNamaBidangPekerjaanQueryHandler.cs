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
using SmmCoreDDD2019.Application.Dto.MasterBidangPekerjaanDBs;

namespace SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan
{
    public class GetNamaBidangPekerjaanQueryHandler : IRequestHandler<GetNamaBidangPekerjaanQuery,IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
     
        public GetNamaBidangPekerjaanQueryHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
           
        }

        public async Task<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>> Handle(GetNamaBidangPekerjaanQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBidangPekerjaanDB.Select(x => new GetNamaBidangPekerjaanResponse
            {
                NoUrutBidangPekerjaan = x.Id,
                NamaMasterBidangPekerjaan = x.NamaMasterBidangPekerjaan

            }).AsNoTracking().ToListAsync();

            return returnQuery;

        }
    }
}
