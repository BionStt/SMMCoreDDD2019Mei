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

namespace SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaan
{
    public class GetNamaPerusahaanHandler : IRequestHandler<GetNamaPerusahaanQuery, GetNamaPerusahaanViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaPerusahaanHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaPerusahaanViewModel> Handle(GetNamaPerusahaanQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaPerusahaanViewModel
            {
                NamaPerusahaanBDs = await _context.DataPerusahaan.ProjectTo<GetNamaPerusahaanLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
    
}
