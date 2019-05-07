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
namespace SmmCoreDDD2019.Application.MasterKategoriBayaranDbs.Query.GetNamaKategoryBayaran
{
    public class GetNamaKategoryBayaranQueryHandler : IRequestHandler<GetNamaKategoryBayaranQuery, GetNamaKategoryBayaranViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaKategoryBayaranQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaKategoryBayaranViewModel> Handle(GetNamaKategoryBayaranQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaKategoryBayaranViewModel
            {
                MasterKategoryBayaranDs = await _context.MasterKategoriBayaran.ProjectTo<GetNamaKategoryBayaranlookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
