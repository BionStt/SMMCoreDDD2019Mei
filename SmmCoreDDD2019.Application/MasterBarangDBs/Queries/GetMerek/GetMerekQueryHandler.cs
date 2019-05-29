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
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMerek
{
    public class GetMerekQueryHandler : IRequestHandler<GetMerekQuery, GetMerekViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetMerekQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
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
