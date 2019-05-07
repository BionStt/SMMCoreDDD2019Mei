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
namespace SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan
{
    public class GetNamaBidangPekerjaanQueryHandler : IRequestHandler<GetNamaBidangPekerjaanQuery, GetNamaBidangPekerjaanViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetNamaBidangPekerjaanQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetNamaBidangPekerjaanViewModel> Handle(GetNamaBidangPekerjaanQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaBidangPekerjaanViewModel
            {
                MasterBidangPekerjaanDs = await _context.MasterBidangPekerjaanDB.ProjectTo<GetNamaBidangPekerjaanLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };

        }
    }
}
