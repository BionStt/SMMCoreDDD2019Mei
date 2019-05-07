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
namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaSalesForce
{
    public class GetNamaSalesForceQueryHandler : IRequestHandler<GetNamaSalesForceQuery, GetNamaSalesForceViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaSalesForceQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaSalesForceViewModel> Handle(GetNamaSalesForceQuery request, CancellationToken cancellationToken)
        {
            // TODO: Set view model state based on user permissions.
          var NamaSales =  await (from a in _context.DataPegawai
                             join c in _context.DataPegawaiDataPribadi on a.IDPegawai equals c.IDPegawai
                             join b in _context.DataPegawaiDataJabatan on a.IDPegawai equals b.IDPegawai
                             where b.NoUrutJabatan == 2 && a.Aktif==null
                             select new {a.IDPegawai,c.NamaDepan }
                             ).OrderBy(x=>x.NamaDepan).ToListAsync(cancellationToken);
          
           var model= new GetNamaSalesForceViewModel
            {
                DataPegawaiDtPribadiDs = _mapper.Map<IEnumerable<GetNamaSalesForceLookUpModel>>(NamaSales)
            };
            return model;
        }
    }
}
