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

namespace SmmCoreDDD2019.Application.Penjualans.Query.GetNamaPenjualanFaktur
{
    public class GetNamaPenjualanFakturQueryHandler : IRequestHandler<GetNamaPenjualanFakturQuery, GetNamaPenjualanFakturViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaPenjualanFakturQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaPenjualanFakturViewModel> Handle(GetNamaPenjualanFakturQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.Penjualan
                            join b in _context.PenjualanDetail on a.Id equals b.PenjualanId
                            join c in _context.CustomerDB on a.CustomerDBId equals c.Id
                            join d in _context.StokUnit on b.StokUnitId equals d.Id
                            join e in _context.MasterBarangDB on d.MasterBarangDBId equals e.Id
                            where _context.PermohonanFakturDB.All(x=>x.PenjualanDetailId!=b.Id)
                        
                           //   where a.Terinput == null
                           select new { NoPenjualanDetail = b.Id, NamaKonsumen1 = string.Format("{0} - {1} - {2} - {3}", d.NoMesin,c.Nama, c.NamaBPKB, e.NamaBarang ) }

             ).ToListAsync(cancellationToken);
            var model = new GetNamaPenjualanFakturViewModel
            {
                DataPenjualanFakturDs = _mapper.Map<IEnumerable<GetNamaPenjualanFakturLookUpModel>>(aa)
            };
            return model;
        }
    }
}
