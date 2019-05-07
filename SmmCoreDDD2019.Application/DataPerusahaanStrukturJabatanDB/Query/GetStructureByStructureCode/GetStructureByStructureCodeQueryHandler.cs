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
namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByStructureCode
{
    public class GetStructureByStructureCodeQueryHandler : IRequestHandler<GetStructureByStructureCodeQuery, GetStructureByStructureCodeViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetStructureByStructureCodeQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
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
