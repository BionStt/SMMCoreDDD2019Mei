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

namespace SmmCoreDDD2019.Application.STNKDBs.Query.GetNamaFakturBPKB
{
    public class GetNamaFakturBPKBQueryHandler : IRequestHandler<GetNamaFakturBPKBQuery, GetNamaFakturBPKBViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaFakturBPKBQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaFakturBPKBViewModel> Handle(GetNamaFakturBPKBQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.PermohonanFakturDB
                            join b in _context.PenjualanDetail on a.PenjualanDetailId equals b.Id
                            join c in _context.Penjualan on b.PenjualanId equals c.Id
                            join d in _context.CustomerDB on c.CustomerDBId equals d.Id
                            join e in _context.StokUnit on b.StokUnitId equals e.Id
                            join f in _context.MasterBarangDB on e.MasterBarangDBId equals f.Id
                            where _context.BPKBDB.All(x => x.PermohonanFakturDBId != a.Id)
                            select new { NoUrutFaktur1 = a.Id, NamaFaktur = string.Format("{0} - {1} - {2}", e.NoMesin, a.NamaFaktur, f.NamaBarang) }

            ).ToListAsync(cancellationToken);
            var model = new GetNamaFakturBPKBViewModel
            {
                DataFakturBPKBDs = _mapper.Map<IEnumerable<GetNamaFakturBPKBlookUpModel>>(aa)
            };
            return model;
            //return new GetNamaPOViewModel
            //{
            //    DataPODS = await _context.PembelianPO.ProjectTo<GetNamaPOLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
