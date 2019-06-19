using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByStructureCode
{
    public class GetStructureByStructureCodeQueryHandler : IRequestHandler<GetStructureByStructureCodeQuery, GetStructureByStructureCodeViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetStructureByStructureCodeQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetStructureByStructureCodeViewModel> Handle(GetStructureByStructureCodeQuery request, CancellationToken cancellationToken)
        {
            return new GetStructureByStructureCodeViewModel
            {
                DataStructureCodeDs = await _context.DataPerusahaanStrukturJabatan.ProjectTo<GetStructureByStructureCodeLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
