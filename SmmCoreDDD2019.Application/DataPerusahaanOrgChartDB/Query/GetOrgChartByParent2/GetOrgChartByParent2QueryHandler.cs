using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParent2
{
    public class GetOrgChartByParent2QueryHandler : IRequestHandler<GetOrgChartByParent2Query, GetOrgChartByParent2ViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetOrgChartByParent2QueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetOrgChartByParent2ViewModel> Handle(GetOrgChartByParent2Query request, CancellationToken cancellationToken)
        {
            var aa = await (from Parent in _context.DataPerusahaanOrgChart
                            from Child in _context.DataPerusahaanOrgChart
                            where Child.Lft > Parent.Lft && Child.Lft < Parent.Rgt && Parent.KodeStrukturJabatan == request.Id
                            orderby Child.KodeStrukturJabatan
                            select new
                            {
                                NoUrutStrukturID = Child.Id,
                                DataAkun = "[" + Child.KodeStrukturJabatan + "] - " + Child.NamaStrukturJabatan

                            }).ToListAsync(cancellationToken);
            var model = new GetOrgChartByParent2ViewModel
            {
                DataOrgChartParent2DCs = _mapper.Map<IEnumerable<GetOrgChartByParent2LookUpModel>>(aa)
            };
            return model;
        }
    }
}
