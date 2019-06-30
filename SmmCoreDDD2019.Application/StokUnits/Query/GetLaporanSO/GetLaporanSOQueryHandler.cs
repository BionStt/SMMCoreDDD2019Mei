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

namespace SmmCoreDDD2019.Application.StokUnits.Query.GetLaporanSO
{
    public class GetLaporanSOQueryHandler : IRequestHandler<GetLaporanSOQuery, GetLaporanSOViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetLaporanSOQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetLaporanSOViewModel> Handle(GetLaporanSOQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.StokUnit
                            join b in _context.MasterBarangDB on a.MasterBarangDBId equals b.Id
                          join c in _context.PembelianDetail on a.PembelianDetailId equals c.Id
                          join d in _context.Pembelian on c.PembelianId equals d.Id
                          join e in _context.MasterSupplierDB on d.MasterSupplierDBId equals e.Id
                          where (a.Jual==null) && (a.Kembali==null)
                            select new
                            {
                                NoUrutSO = a.Id,
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
