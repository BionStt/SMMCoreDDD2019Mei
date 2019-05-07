using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Persistence;
using System.Threading;

namespace SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha
{
    public class GetNamaBidangUsahaQueryHandler : IRequestHandler<GetNamaBidangUsahaQuery, GetNamaBidangUsahaViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetNamaBidangUsahaQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaBidangUsahaViewModel> Handle(GetNamaBidangUsahaQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaBidangUsahaViewModel
            {
                MasterBidangUsahaDs = await _context.MasterBidangUsahaDB.ProjectTo<GetNamaBidangUsahaLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
