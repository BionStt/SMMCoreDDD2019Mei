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

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByDepth
{
    public class GetOrgChartByDepthQueryHandler : IRequestHandler<GetOrgChartByDepthQuery, GetOrgChartByDepthViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetOrgChartByDepthQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetOrgChartByDepthViewModel> Handle(GetOrgChartByDepthQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataPerusahaanOrgChart
                            from b in _context.DataPerusahaanOrgChart
                            where a.Parent == b.Id.ToString() && (a.Depth == 3)

                            select new
                            {
                                NoUrutStrukturID = a.Id,
                                NamaStrukturJabatan = b.NamaStrukturJabatan,
                                KodeStruktur = a.KodeStrukturJabatan,
                                DataAkun1 = "[" + a.KodeStrukturJabatan + "] - " + a.NamaStrukturJabatan,
                                DataAkun2 = b.KodeStrukturJabatan+ " - " + b.NamaStrukturJabatan
                            }
                ).ToListAsync(cancellationToken);

            var model = new GetOrgChartByDepthViewModel
            {
                DataStructureByDepthDS = _mapper.Map<IEnumerable<GetOrgChartByDepthLookUpModel>>(aa)
            };
            return model;
        }
    }
}
