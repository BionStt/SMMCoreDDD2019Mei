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

namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Queries.GetNamaSupplier
{
    public class GetNamaSupplierHandler : IRequestHandler<GetNamaSupplierQuery, GetNamaSupplierViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaSupplierHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
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
