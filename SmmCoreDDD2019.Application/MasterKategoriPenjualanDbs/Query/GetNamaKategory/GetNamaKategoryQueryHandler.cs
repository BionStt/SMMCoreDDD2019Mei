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
namespace SmmCoreDDD2019.Application.MasterKategoriPenjualanDbs.Query.GetNamaKategory
{
    public class GetNamaKategoryQueryHandler : IRequestHandler<GetNamaKategoryQuery, GetNamaKategoryViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaKategoryQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaKategoryViewModel> Handle(GetNamaKategoryQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaKategoryViewModel
            {
                MasterKategoryPenjualanDs = await _context.MasterKategoriPenjualan.ProjectTo<GetNamaKategoryLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
