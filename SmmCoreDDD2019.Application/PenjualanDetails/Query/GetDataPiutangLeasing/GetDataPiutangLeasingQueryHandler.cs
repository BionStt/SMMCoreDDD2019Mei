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


namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasing
{
    public class GetDataPiutangLeasingQueryHandler : IRequestHandler<GetDataPiutangLeasingQuery, GetDataPiutangLeasingViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataPiutangLeasingQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataPiutangLeasingViewModel> Handle(GetDataPiutangLeasingQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.Penjualan
                            join b in _context.PenjualanDetail on a.Id equals b.PenjualanId
                            join c in _context.CustomerDB on a.CustomerDBId equals c.Id
                            join d in _context.StokUnit on b.StokUnitId equals d.Id
                            join e in _context.MasterBarangDB on d.MasterBarangDBId equals e.Id
                            join f in _context.MasterKategoriPenjualan on a.MasterKategoriPenjualanId equals f.Id
                            join g in _context.MasterLeasingCabangDB on a.MasterLeasingCabangDBId equals g.Id
                            join h in _context.MasterLeasingDb on g.MasterLeasingDbId equals h.Id
                            join i in _context.DataPegawaiDataPribadi on a.NoUrutSales equals i.Id
                            join j in _context.PembelianDetail on d.PembelianDetailId equals j.Id
                            join k in _context.Pembelian on j.PembelianId equals k.Id
                            join l in _context.MasterSupplierDB on k.MasterSupplierDBId equals l.Id
                            where g.Id== Int32.Parse(request.IdLeasing) && _context.PenjualanPiutang.All(x=>x.PenjualanDetailId!=b.Id)
                            select new
                            {
                                NoUrutPenjualanDetail = b.Id,
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
                                NamaSupplier=l.NamaSupplier
                            }

                   ).ToListAsync(cancellationToken);
            var model = new GetDataPiutangLeasingViewModel
            {
                DataPiutangLeasingDS = _mapper.Map<IEnumerable<GetDataPiutangLeasingLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
