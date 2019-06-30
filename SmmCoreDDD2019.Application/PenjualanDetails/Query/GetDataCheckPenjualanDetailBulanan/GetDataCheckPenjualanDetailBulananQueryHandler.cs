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

namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanDetailBulanan
{
    public class GetDataCheckPenjualanDetailBulananQueryHandler : IRequestHandler<GetDataCheckPenjualanDetailBulananQuery, GetDataCheckPenjualanDetailBulananViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataCheckPenjualanDetailBulananQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataCheckPenjualanDetailBulananViewModel> Handle(GetDataCheckPenjualanDetailBulananQuery request, CancellationToken cancellationToken)
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
                            join m in _context.PermohonanFakturDB on b.Id equals m.PenjualanDetailId into ps
                            join n in _context.PenjualanPiutang on b.Id equals n.PenjualanDetailId into ps1
                            from m in ps.DefaultIfEmpty()
                            from n in ps1.DefaultIfEmpty()
                            where b.Id ==Int32.Parse(request.Id)
                            select new
                            {
                                NoFaktur = (m == null ? 0 : m.Id),
                                // passengerType = pd == null ? String.Empty : pd.PassengerType
                                TglLunasLeasing1 = (n.TanggalLunas == null ? (Nullable<DateTime>)null : n.TanggalLunas),
                           
                                NoUrutPenjualanDetail = b.Id,
                                KodeKonsumen = c.Id,
                                NamaKonsumen = c.Nama,
                                NamaBPKB = c.NamaBPKB,
                                NamaFaktur = m.NamaFaktur,
                                NoUrutPenjualan = a.Id,
                                TanggalPenjualan = a.TanggalPenjualan,
                                Merek = e.Merek,
                                NamaBarang = e.NamaBarang,
                                Warna = d.Warna,
                                NoRangka = d.NoRangka,
                                NoMesin = d.NoMesin,
                                SalesForce = i.NamaDepan,
                                KategoriPenjualan = f.NamaKategoryPenjualan,
                                Mediator1 = a.Mediator,
                                NamaSupplier = l.NamaSupplier,
                                DiskonUnit = d.Diskon,
                                SellIn = d.SellIn,
                                NoUrutSO = d.Id,
                                TanggalBeliUnit = k.TglBeli,
                                HargaOTR = b.HargaOTR,
                                UangMuka = b.UangMuka,
                                DiskonKredit = b.DiskonKredit,
                                DPBayar = ((b.UangMuka) - (b.DiskonKredit)),
                                DiskonTunai = b.DiskonTunai,
                                Subsidi1 = b.Subsidi,
                                Promosi1 = b.Promosi,
                                Komisi1 = b.Komisi,
                                JoinPromo2 = b.JoinPromo1,
                                JoinPromo1 = b.JoinPromo2,
                                SPF1 = b.SPF,
                                SellOut1 = b.SellOut,
                                DendaWilayah1 = b.DendaWilayah,
                                Tagihan1 = ((b.HargaOTR) - (b.UangMuka)),
                                TotalTagihan1 = ((b.HargaOTR) - (b.UangMuka) + (b.JoinPromo1)),
                                NamaLeasing = h.NamaLease,
                                CabangLeasing = g.Cabang,
                                NomorPO = a.Keterangan,
                                NoBuku1 = a.NoBuku,
                                ProfitUnit = ((d.Diskon) + (d.SellIn) + (b.JoinPromo1) + (b.JoinPromo2) + (b.SPF) - (b.DiskonKredit) - (b.DiskonTunai) - (b.Komisi) - (b.Promosi) - (b.SellOut))
                            }

                    ).ToListAsync(cancellationToken);
            var model = new GetDataCheckPenjualanDetailBulananViewModel
            {
                GetDataPenjualanDetailByNosinDS = _mapper.Map<IEnumerable<GetDataCheckPenjualanDetailBulananLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
