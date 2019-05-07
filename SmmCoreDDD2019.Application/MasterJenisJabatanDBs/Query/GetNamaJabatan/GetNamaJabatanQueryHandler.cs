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
namespace SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Query.GetNamaJabatan
{
    public class GetNamaJabatanQueryHandler : IRequestHandler<GetNamaJabatanQuery, GetNamaJabatanViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaJabatanQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaJabatanViewModel> Handle(GetNamaJabatanQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaJabatanViewModel
            {
                MasterJenisJabatanDs = await _context.MasterJenisJabatan.ProjectTo<GetNamaJabatanLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
