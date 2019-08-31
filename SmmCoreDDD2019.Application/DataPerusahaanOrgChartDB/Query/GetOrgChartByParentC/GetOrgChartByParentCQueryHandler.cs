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

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParentC
{
    public class GetOrgChartByParentCQueryHandler : IRequestHandler<GetOrgChartByParentCQuery, GetOrgChartByParentCViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetOrgChartByParentCQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetOrgChartByParentCViewModel> Handle(GetOrgChartByParentCQuery request, CancellationToken cancellationToken)
        {
            //var aa = await (from a in _context.DataPerusahaanOrgChart
            //                orderby a.KodeStrukturJabatan
            //                where (a.Parent == null)
            //                select new
            //                {
            //                    NoUrutStrukturID = a.Id,
            //                    DataAkun1 = "[" + a.KodeStrukturJabatan + "] - " + a.NamaStrukturJabatan
            //                    //string.format("{0}", "[" + a.KodeStrukturJabatan + "] - " + a.NamaStrukturJabatan)
            //                })
            //            // .ProjectTo<GetStructureByParentLookUpModel>(_mapper.ConfigurationProvider)
            //            .ToListAsync(cancellationToken);
            var model = new GetOrgChartByParentCViewModel
            {
                DataOrgChartParentCDs = await _context.DataPerusahaanOrgChart.ProjectTo<GetOrgChartByParentCLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
               // DataOrgChartParentCDs = _mapper.Map<IEnumerable<GetOrgChartByParentCLookUpModel>>(aa)
            };
            return model;

        }
    }
}
