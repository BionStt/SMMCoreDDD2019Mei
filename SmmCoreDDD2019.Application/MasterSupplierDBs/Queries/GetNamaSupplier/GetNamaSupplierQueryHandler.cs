using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Queries.GetNamaSupplier
{
    public class GetNamaSupplierQueryHandler : IRequestHandler<GetNamaSupplierQuery, GetNamaSupplierViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaSupplierQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetNamaSupplierViewModel> Handle(GetNamaSupplierQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaSupplierViewModel
            {
                MasterSupplierDs = await _context.MasterSupplierDB.ProjectTo<GetNamaSupplierLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
