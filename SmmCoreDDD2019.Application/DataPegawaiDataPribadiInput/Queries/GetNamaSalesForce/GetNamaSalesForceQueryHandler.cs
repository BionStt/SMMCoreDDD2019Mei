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
namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaSalesForce
{
    public class GetNamaSalesForceQueryHandler : IRequestHandler<GetNamaSalesForceQuery, GetNamaSalesForceViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaSalesForceQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaSalesForceViewModel> Handle(GetNamaSalesForceQuery request, CancellationToken cancellationToken)
        {
            // TODO: Set view model state based on user permissions.
          var NamaSales =  await (from a in _context.DataPegawai
                             join c in _context.DataPegawaiDataPribadi on a.Id equals c.DataPegawaiId
                             join b in _context.DataPegawaiDataJabatan on a.Id equals b.DataPegawaiId
                                  where b.Id == 2 && a.Aktif==null
                             select new {a.Id,c.NamaDepan }
                             ).OrderBy(x=>x.NamaDepan).ToListAsync(cancellationToken);
          
           var model= new GetNamaSalesForceViewModel
            {
                DataPegawaiDtPribadiDs = _mapper.Map<IEnumerable<GetNamaSalesForceLookUpModel>>(NamaSales)
            };
            return model;
        }
    }
}
