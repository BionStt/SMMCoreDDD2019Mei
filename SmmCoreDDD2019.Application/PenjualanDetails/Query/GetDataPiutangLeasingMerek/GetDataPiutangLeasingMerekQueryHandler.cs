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

namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasingMerek
{
    public class GetDataPiutangLeasingMerekQueryHandler : IRequestHandler<GetDataPiutangLeasingMerekQuery, GetDataPiutangLeasingMerekViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataPiutangLeasingMerekQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataPiutangLeasingMerekViewModel> Handle(GetDataPiutangLeasingMerekQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.Penjualan
                           join b in _context.PenjualanDetail on a.KodePenjualan equals b.KodePenjualan
                           join c in _context.CustomerDB on a.KodeKonsumen equals c.CustomerID
                           join d in _context.StokUnit on b.NoUrutSO equals d.NoUrutSo
                           join e in _context.MasterBarangDB on d.KodeBrg equals e.NoUrutTypeKendaraan
                           join f in _context.MasterKategoriPenjualan on a.KategoriPenjualan equals f.NoUrutKategoriPenjualan
                           join g in _context.MasterLeasingCabangDB on a.KodeLease equals g.NoUrutLeasingCabang
                           join h in _context.MasterLeasingDb on g.IDlease equals h.IDlease
                           join i in _context.DataPegawaiDataPribadi on a.NoUrutSales equals i.IDPegawai
                           join j in _context.PembelianDetail on d.KodeBeliDetail equals j.KodeBeliDetail
                           join k in _context.Pembelian on j.KodeBeli equals k.KodeBeli
                           join l in _context.MasterSupplierDB on k.Idsupplier equals l.IDSupplier
                           where g.NoUrutLeasingCabang == Int32.Parse(request.IdLeasing) && _context.PenjualanPiutang.All(x => x.KodePenjualanDetail != b.NoPenjualanDetail.ToString())
                           select new
                           {
                               NoUrutPenjualanDetail = b.NoPenjualanDetail,
                               NamaKonsumen = c.Nama,
                               NamaBPKB = c.NamaBPKB,
                               AlamatKonsumen = c.Alamat,
                               KelurahanK = c.Kelurahan,
                               KecamatanK = c.Kecamatan,
                               KotaK = c.Kota,
                               PropinsiK = c.Propinsi,
                               KodePosK = c.KodePos,
                               NoTelepon = c.Telp,
                               NoHandphone = c.Handphone,
                               Keterangan = a.Keterangan,
                               NoBuku = a.NoBuku,
                               Merek = e.Merek,
                               NamaBarang = e.NamaBarang,
                               TypeKendaraan1 = e.TypeKendaraan,
                               Noka1 = e.NomorRangka,
                               Nosin1 = e.NomorMesin,
                               NoRangka = d.NoRangka,
                               NoMesin = d.NoMesin,
                               Warna = d.Warna,
                               UangMuka = b.UangMuka,
                               DiskonKredit1 = b.DiskonKredit,
                               DiskonTunai1 = b.DiskonTunai,
                               DendaWilayah = b.DendaWilayah,
                               HargaOtr1 = b.HargaOTR,
                               JoinPromo1 = b.JoinPromo1,
                               JoinPromo2 = b.JoinPromo2,
                               Komisi = b.Komisi,
                               OffTheRoad = b.OffTheRoad,
                               BBN = b.BBN,
                               Promosi = b.Promosi,
                               SellOut = b.SellOut,
                               SPF = b.SPF,
                               Subdisi = b.Subsidi,
                               Mediator1 = a.Mediator,
                               NamaSales = i.NamaDepan,
                               HandphoneSales = i.Handphone,
                               KategoriPenjualan = f.NamaKategoryPenjualan,
                               NamaLeasing = h.NamaLease,
                               CabangLeasing = g.Cabang,
                               DpBayar = ((b.UangMuka) - (b.DiskonKredit)),
                               HargaTagihan = ((b.HargaOTR) - (b.UangMuka)),
                               TanggalPenjualan = a.TanggalPenjualan,
                               NamaSupplier = l.NamaSupplier
                           }

                  ).ToListAsync(cancellationToken);
            var model = new GetDataPiutangLeasingMerekViewModel
            {
                DataPiutangLeasingMerekDS = _mapper.Map<IEnumerable<GetDataPiutangLeasingMerekLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
