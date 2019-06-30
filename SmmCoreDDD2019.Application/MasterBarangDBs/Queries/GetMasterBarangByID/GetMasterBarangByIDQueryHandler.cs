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
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMasterBarangByID
{
    public class GetMasterBarangByIDQueryHandler : IRequestHandler<GetMasterBarangByIDQuery, GetMasterBarangByIDViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetMasterBarangByIDQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetMasterBarangByIDViewModel> Handle(GetMasterBarangByIDQuery request, CancellationToken cancellationToken)
        {
            return new GetMasterBarangByIDViewModel
            {
                MasterBarangDs = await _context.MasterBarangDB.Where(x=>x.Id==Int32.Parse(request.Id)).ProjectTo<GetMasterBarangByIDLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
