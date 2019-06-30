using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByParentC
{
    public class GetStructureByParentCQueryHandler : IRequestHandler<GetStructureByParentCQuery, GetStructureByParentCViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetStructureByParentCQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetStructureByParentCViewModel> Handle(GetStructureByParentCQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataPerusahaanStrukturJabatan
                            orderby a.KodeStruktur
                            where (a.Parent == null)
                            select new
                            {
                                NoUrutStrukturID = a.Id,
                                DataAkun1 = "[" + a.KodeStruktur + "] - " + a.NamaStrukturJabatan
                            })
                          // .ProjectTo<GetStructureByParentLookUpModel>(_mapper.ConfigurationProvider)
                          .ToListAsync(cancellationToken);
            var model = new GetStructureByParentCViewModel
            {
                StructureDataParentCDs = _mapper.Map<IEnumerable<GetStructureByParentCLookUpModel>>(aa)
            };
            return model;

        }
    }
}
