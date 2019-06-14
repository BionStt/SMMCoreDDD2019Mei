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

using System.Data.SqlClient;


namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByParent
{
    public class GetStructureByParentQueryHandler : IRequestHandler<GetStructureByParentQuery, GetStructureByParentViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetStructureByParentQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetStructureByParentViewModel> Handle(GetStructureByParentQuery request, CancellationToken cancellationToken)
        {
            //var aa = await _context.DataPerusahaanStrukturJabatan
            //        .FromSql($"SELECT *, '[' + KodeStruktur + '] - ' + NamaStrukturJabatan AS DataAkun FROM   DataPerusahaan.DataPerusahaanStrukturJabatan WHERE (Parent IS NULL) ORDER BY KodeStruktur")
            //        .AsNoTracking()
            //        .ToListAsync();

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
                // StructureDataParentDs = _mapper.Map<GetStructureByParentLookUpModel[]>(aa)
                //StructureDataParentDs = _mapper.Map<IList<GetStructureByParentLookUpModel>>(aa)
                StructureDataParentDs = _mapper.Map<IEnumerable<GetStructureByParentLookUpModel>>(aa)
            };
            return model;
        }
    }
}
