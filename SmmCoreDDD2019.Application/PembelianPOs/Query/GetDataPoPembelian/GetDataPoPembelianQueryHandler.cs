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

namespace SmmCoreDDD2019.Application.PembelianPOs.Query.GetDataPoPembelian
{
    public class GetDataPoPembelianQueryHandler : IRequestHandler<GetDataPoPembelianQuery, GetDataPoPembelianViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataPoPembelianQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataPoPembelianViewModel> Handle(GetDataPoPembelianQuery request, CancellationToken cancellationToken)
        {
            return new GetDataPoPembelianViewModel
            {
                DataPembelianPODs = await _context.PembelianPO.ProjectTo<GetDataPoPembelianLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
