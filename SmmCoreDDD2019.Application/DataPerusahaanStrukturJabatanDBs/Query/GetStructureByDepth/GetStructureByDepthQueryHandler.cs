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

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByDepth
{
    public class GetStructureByDepthQueryHandler : IRequestHandler<GetStructureByDepthQuery, GetStructureByDepthViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetStructureByDepthQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<GetStructureByDepthViewModel> Handle(GetStructureByDepthQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataPerusahaanStrukturJabatan
                            from b in _context.DataPerusahaanStrukturJabatan
                            where a.Parent == b.NoUrutStrukturID.ToString() && (a.Depth == 3)

                            select new
                            {
                                NoUrutStrukturID = a.NoUrutStrukturID,
                                NamaStrukturJabatan = b.NamaStrukturJabatan,
                                KodeStruktur = a.KodeStruktur,
                                DataAkun1 = "[" + a.KodeStruktur + "] - " + a.NamaStrukturJabatan,
                                DataAkun2 = b.KodeStruktur + " - " + b.NamaStrukturJabatan
                            }
               ).ToListAsync(cancellationToken);

            var model = new GetStructureByDepthViewModel
            {
                DataStructureByDepthDS = _mapper.Map<IEnumerable<GetStructureByDepthLookUpModel>>(aa)
            };
            return model;
        }
    }
}

