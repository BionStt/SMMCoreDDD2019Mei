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
namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByParent2
{
    public class GetStructureByParent2QueryHandler : IRequestHandler<GetStructureByParent2Query, GetStructureByParent2ViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetStructureByParent2QueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetStructureByParent2ViewModel> Handle(GetStructureByParent2Query request, CancellationToken cancellationToken)
        {
            var aa = await (from Parent in _context.DataPerusahaanStrukturJabatan
                            from Child in _context.DataPerusahaanStrukturJabatan
                            where Child.Lft > Parent.Lft && Child.Lft < Parent.Rgt && Parent.KodeStruktur == request.Id
                            orderby Child.KodeStruktur
                            select new
                            {
                                NoUrutAccountId = Child.NoUrutStruktur,
                                DataAkun = "[" + Child.KodeStruktur + "] - " + Child.NamaStrukturJabatan 

                            }).ToListAsync(cancellationToken);
            var model = new GetStructureByParent2ViewModel
            {
                DataStructureParent2Ds = _mapper.Map<IEnumerable<GetStructureByParent2LookUpModel>>(aa)
            };
            return model;
        }
    }
}
