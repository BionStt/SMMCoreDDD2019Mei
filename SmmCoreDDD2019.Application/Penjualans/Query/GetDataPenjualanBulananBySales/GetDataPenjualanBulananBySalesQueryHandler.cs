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

namespace SmmCoreDDD2019.Application.Penjualans.Query.GetDataPenjualanBulananBySales
{
    public class GetDataPenjualanBulananBySalesQueryHandler : IRequestHandler<GetDataPenjualanBulananBySalesQuery, GetDataPenjualanBulananBySalesViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataPenjualanBulananBySalesQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataPenjualanBulananBySalesViewModel> Handle(GetDataPenjualanBulananBySalesQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.Penjualan
                           join b in _context.MasterKategoriPenjualan on a.MasterKategoriPenjualanId equals b.Id
                           join c in _context.CustomerDB on a.CustomerDBId equals c.Id
                           join d in _context.PenjualanDetail on a.Id equals d.PenjualanId
                           join e in _context.StokUnit on d.StokUnitId equals e.Id
                           join f in _context.PembelianDetail on e.PembelianDetailId equals f.Id
                           join g in _context.Pembelian on f.PembelianId equals g.Id
                           join h in _context.MasterSupplierDB on g.MasterSupplierDBId equals h.Id
                           join i in _context.MasterBarangDB on e.MasterBarangDBId equals i.Id
                           join j in _context.MasterLeasingCabangDB on a.MasterLeasingCabangDBId equals j.Id
                           join k in _context.MasterLeasingDb on j.MasterLeasingDbId equals k.Id
                           join l in _context.DataPegawaiDataPribadi on a.NoUrutSales equals l.Id
                           join m in _context.PenjualanPiutang on d.Id equals m.PenjualanDetailId into ps
                           from m in ps.DefaultIfEmpty()
                           where (a.TanggalPenjualan <= request.PeriodeAkhir && a.TanggalPenjualan >= request.PeriodeAwal) && l.DataPegawaiId ==Int32.Parse(request.NoUrutSales)
                           //   where a.Terinput == null
                           select new
                           {
                               KodePenjualanID = a.Id,
                               TanggalPenjualan = a.TanggalPenjualan,
                               NoBuku = a.NoBuku,
                               NamaKonsumen = c.Nama,
                               NamaBPKB = c.NamaBPKB,
                               AlamatKonsumen = c.Alamat,
                               Kelurahan = c.Kelurahan,
                               Kecamatan = c.Kecamatan,
                               Kota = c.Kota,
                               Propipnsi = c.Propinsi,
                               Handphone = c.Handphone,
                               Telepon = c.Telp,
                               Merek = i.Merek,
                               NamaBarang = i.NamaBarang,
                               NamaLeasing = k.NamaLease,
                               CabangLeasing = j.Cabang,
                               NamaSales = l.NamaDepan,
                               Supplier = h.NamaSupplier,

                               KategoryPenjualan = b.NamaKategoryPenjualan,
                               NoRangka = e.NoRangka,
                               NoMesin = e.NoMesin,
                               OTR = d.HargaOTR,
                               DiscTunai = d.DiskonTunai,
                               OTRByr = ((d.HargaOTR) - (d.DiskonTunai)),
                               DP = d.UangMuka,
                               DiscDP = d.DiskonKredit,
                               DPByr = ((d.UangMuka) - (d.DiskonKredit)),
                               SPFF = d.SPF,
                               SellOutt = d.SellOut,
                               DenWil = d.DendaWilayah,
                               SubK = d.Subsidi,
                               Komisii = d.Komisi,
                               JPI = d.JoinPromo1,
                               JPII = d.JoinPromo2,
                               Promosi1 = d.Promosi,
                               tglLunasLeasing = (m.TanggalLunas == null ? (Nullable<DateTime>)null : m.TanggalLunas)


                           }

            ).ToListAsync(cancellationToken);
            var model = new GetDataPenjualanBulananBySalesViewModel
            {
                DataPenjualanBulananSalesDS = _mapper.Map<IEnumerable<GetDataPenjualanBulananBySalesLookUpModel>>(aa)
            };
            return model;
        }
    }
}
