using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetDataPenjualanHarian
{
    public class GetDataPenjualanHarianQueryHandler : IRequestHandler<GetDataPenjualanHarianQuery, IReadOnlyCollection<GetDataPenjualanHarianResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetDataPenjualanHarianQueryHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<IReadOnlyCollection<GetDataPenjualanHarianResponse>> Handle(GetDataPenjualanHarianQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.DataPenjualan
                            join b in _context.MasterKategoriPenjualan on a.MasterKategoriPenjualanId equals b.MasterKategoriPenjualanId
                            join c in _context.DataKonsumen on a.DataKonsumenId equals c.DataKonsumenId
                            join d in _context.DataPenjualanDetail on a.DataPenjualanId equals d.DataPenjualanId
                            join e in _context.StokUnit on d.StokUnitId equals e.StokUnitId
                           // join f in _inventoryContext.PembelianDetail on e.PembelianDetailId equals f.PembelianDetailId
                            //join g in _inventoryContext.Pembelian on f.PembelianId equals g.PembelianId
                            //join h in _inventoryContext.Supplier on g.SupplierId equals h.SupplierId
                            join i in _context.MasterBarang on e.MasterBarangId equals i.MasterBarangId
                            join j in _context.MasterLeasingCabang on a.MasterLeasingCabangId equals j.MasterLeasingCabangId
                            join k in _context.MasterLeasing on j.MasterLeasingId equals k.MasterLeasingId
                            join l in _context.DataSalesMarketing on a.SalesUserId equals l.DataSalesMarketingId // into ps
                          //  join m in _context.PenjualanPiutang on d.Id equals m.PenjualanDetailId into ps
                           // from m in ps.DefaultIfEmpty()
                            where (a.TanggalPenjualan <= request.PeriodeAkhir && a.TanggalPenjualan >= request.PeriodeAwal)
                            //   where a.Terinput == null
                            select new GetDataPenjualanHarianResponse
                            {
                                KodePenjualanID = a.NoUrutId,
                                TanggalPenjualan = a.TanggalPenjualan,
                                NoBuku = a.NoBuku,
                                NamaKonsumen = c.Nama.NamaDepan ,
                                NamaBPKB = c.NamaBPKB.NamaDepan,
                                AlamatKonsumen = c.AlamatTinggal.Jalan,
                                Kelurahan = c.AlamatTinggal.Kelurahan,
                                Kecamatan = c.AlamatTinggal.Kecamatan,
                                Kota = c.AlamatTinggal.Kota,
                                Propinsi = c.AlamatTinggal.Propinsi,
                                Handphone = c.AlamatTinggal.NoHandphone,
                                Telepon = c.AlamatTinggal.NoTelepon,
                                Merek = i.Merek,
                                NamaBarang = i.NamaBarang,
                                NamaLeasing = k.NamaLeasing,
                                CabangLeasing = j.NamaCabang,
                                NamaSales = l.NamaSales,
                                Supplier = e.NamaSupplier,

                                KategoryPenjualan = b.NamaKategoryPenjualan,
                                NoRangka = e.NomorRangka,
                                NoMesin = e.NomorMesin,
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
                               // tglLunasLeasing = (m.TanggalLunas == null ? (Nullable<DateTime>)null : m.TanggalLunas)


                            }

           ).OrderBy(x=>x.TanggalPenjualan).ToListAsync();
         

            return returnQuery;
        }
    }
}
