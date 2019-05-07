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

namespace SmmCoreDDD2019.Application.StokUnits.Query.GetLaporanSO
{
    public class GetLaporanSOQueryHandler : IRequestHandler<GetLaporanSOQuery, GetLaporanSOViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetLaporanSOQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetLaporanSOViewModel> Handle(GetLaporanSOQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.StokUnit
                            join b in _context.MasterBarangDB on a.KodeBrg equals b.NoUrutTypeKendaraan
                          join c in _context.PembelianDetail on a.KodeBeliDetail equals c.KodeBeliDetail
                          join d in _context.Pembelian on c.KodeBeli equals d.KodeBeli
                          join e in _context.MasterSupplierDB on d.Idsupplier equals e.IDSupplier
                          where (a.Jual==null) && (a.Kembali==null)
                            select new
                            {
                                NoUrutSO = a.NoUrutSo,
                                NamaBarang1 = b.NamaBarang,
                                  TypeKendaraan  =b.TypeKendaraan,
                                  Merek1  =b.Merek,
                                  NoRangka  =a.NoRangka,
                                  NoMesin  =a.NoMesin,
                                  Warna  =a.Warna,
                                TanggalBeli  =d.TglBeli,
                                  NamaSupplier  =e.NamaSupplier

    }

                ).ToListAsync(cancellationToken);
            var model = new GetLaporanSOViewModel
            {
                LaporanSODs = _mapper.Map<IEnumerable<GetLaporanSOLookUpModel>>(aa)
            };
            return model;
            //return new GetDataSOViewModel
            //{
            //    DataSODs = await _context.PembelianPO.ProjectTo<GetDataSOLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
