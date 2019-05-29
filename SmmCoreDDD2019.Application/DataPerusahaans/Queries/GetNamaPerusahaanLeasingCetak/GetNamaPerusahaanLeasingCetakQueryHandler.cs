
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaanLeasingCetak
{
    public class GetNamaPerusahaanLeasingCetakQueryHandler : IRequestHandler<GetNamaPerusahaanLeasingCetakQuery, GetNamaPerusahaanLeasingCetakViewModal>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaPerusahaanLeasingCetakQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaPerusahaanLeasingCetakViewModal> Handle(GetNamaPerusahaanLeasingCetakQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaPerusahaanLeasingCetakViewModal
            {
                NamaPerusahaanBDs = await _context.DataPerusahaan.ProjectTo<GetNamaPerusahaanLeasingCetakLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
