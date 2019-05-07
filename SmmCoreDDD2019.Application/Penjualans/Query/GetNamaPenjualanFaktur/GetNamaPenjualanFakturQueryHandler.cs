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
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetNamaPenjualanFaktur
{
    public class GetNamaPenjualanFakturQueryHandler : IRequestHandler<GetNamaPenjualanFakturQuery, GetNamaPenjualanFakturViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaPenjualanFakturQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaPenjualanFakturViewModel> Handle(GetNamaPenjualanFakturQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.Penjualan
                            join b in _context.PenjualanDetail on a.KodePenjualan equals b.KodePenjualan
                            join c in _context.CustomerDB on a.KodeKonsumen equals c.CustomerID
                            join d in _context.StokUnit on b.NoUrutSO equals d.NoUrutSo
                            join e in _context.MasterBarangDB on d.KodeBrg equals e.NoUrutTypeKendaraan
                            where _context.PermohonanFakturDB.All(x=>x.KodePenjualanDetail!=b.NoPenjualanDetail)
                        
                           //   where a.Terinput == null
                           select new { NoPenjualanDetail = b.NoPenjualanDetail, NamaKonsumen1 = string.Format("{0} - {1} - {2} - {3}", d.NoMesin,c.Nama, c.NamaBPKB, e.NamaBarang ) }

             ).ToListAsync(cancellationToken);
            var model = new GetNamaPenjualanFakturViewModel
            {
                DataPenjualanFakturDs = _mapper.Map<IEnumerable<GetNamaPenjualanFakturLookUpModel>>(aa)
            };
            return model;
        }
    }
}
