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
namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByParent
{
    public class GetStructureByParentQueryHandler : IRequestHandler<GetStructureByParentQuery, GetStructureByParentViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetStructureByParentQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetStructureByParentViewModel> Handle(GetStructureByParentQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataPerusahaanStrukturJabatan
                            orderby a.KodeStruktur
                            where (a.Parent == null)
                            select new
                            {
                                NoUrutStrukturID = a.NoUrutStrukturID,
                                DataAkun = "[" + a.KodeStruktur + "] - " + a.NamaStrukturJabatan 


                            }).ToListAsync(cancellationToken);
            var model = new GetStructureByParentViewModel
            {
                StructureDataParentDs = _mapper.Map<IEnumerable<GetStructureByParentLookUpModel>>(aa)
            };
            return model;
        }
    }
}
