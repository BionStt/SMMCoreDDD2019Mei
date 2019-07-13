using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByDepthByChart
{
    public class GetOrgChartByDepthByChartQueryHandler : IRequestHandler<GetOrgChartByDepthByChartQuery, GetOrgChartByDepthByChartViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetOrgChartByDepthByChartQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetOrgChartByDepthByChartViewModel> Handle(GetOrgChartByDepthByChartQuery request, CancellationToken cancellationToken)
        {
            return new GetOrgChartByDepthByChartViewModel
            {
                DataStructureCodeDs = await _context.DataPerusahaanOrgChart.ProjectTo<GetOrgChartByDepthByChartLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
