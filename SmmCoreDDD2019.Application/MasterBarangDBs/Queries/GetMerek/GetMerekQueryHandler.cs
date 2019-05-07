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
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMerek
{
    public class GetMerekQueryHandler : IRequestHandler<GetMerekQuery, GetMerekViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetMerekQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetMerekViewModel> Handle(GetMerekQuery request, CancellationToken cancellationToken)
        {
            return new GetMerekViewModel
            {
                MasterBarangMerekDs = await _context.MasterBarangDB.ProjectTo<GetMerekLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
