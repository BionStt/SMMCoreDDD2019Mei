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


namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Queries.GetAllLeasing
{
    public class GetAllLeasingQueryHandler : IRequestHandler<GetAllLeasingQuery, GetAllLeasingViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetAllLeasingQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetAllLeasingViewModel> Handle(GetAllLeasingQuery request, CancellationToken cancellationToken)
        {
            return new GetAllLeasingViewModel
            {
                MasterLeasingDs = await _context.MasterLeasingDb.ProjectTo<GetAllLeasinglookupModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };

        }
    }
}
