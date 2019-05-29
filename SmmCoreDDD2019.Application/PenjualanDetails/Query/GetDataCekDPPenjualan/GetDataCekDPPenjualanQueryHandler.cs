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


namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPPenjualan
{
    public class GetDataCekDPPenjualanQueryHandler : IRequestHandler<GetDataCekDPPenjualanQuery, GetDataCekDPPenjualanViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataCekDPPenjualanQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataCekDPPenjualanViewModel> Handle(GetDataCekDPPenjualanQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.Penjualan
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
                            join m in _context.PermohonanFakturDB on b.NoPenjualanDetail equals m.KodePenjualanDetail

                            where b.NoPenjualanDetail == Int32.Parse(request.Id)
                            select new
                            {
                                   NoUrutPenjualanDetail   = b.NoPenjualanDetail,
                                  KodeKonsumen  = c.CustomerID,
                                  NamaKonsumen  =c.Nama,
                                  NamaBPKB  =c.NamaBPKB,
                                  NamaFaktur  =m.NamaFaktur,
                                  NoUrutPenjualan  =a.KodePenjualan,
                                TanggalPenjualan  =a.TanggalPenjualan,
                                  Merek  =e.Merek,
                                  NamaBarang  =e.NamaBarang,
                                  Warna  =d.Warna,
                                  NoRangka  =d.NoRangka,
                                  NoMesin  =d.NoMesin,
                                  SalesForce  =i.NamaDepan,
                                  KategoriPenjualan  =f.NamaKategoryPenjualan,
                                  Mediator1  =a.Mediator,
                                  NamaSupplier  =l.NamaSupplier,
                                  DiskonUnit  =d.Diskon,
                                  SellIn  =d.SellIn,
                                  NoUrutSO  =d.NoUrutSo,
                                  TanggalBeliUnit  =k.TglBeli,
                                  HargaOTR  =b.HargaOTR,
                                  UangMuka  =b.UangMuka,
                                  DiskonKredit  =b.DiskonKredit,
                                  DPBayar  =((b.UangMuka)-(b.DiskonKredit)),
                                  DiskonTunai  =b.DiskonTunai,
                                  Subsidi1  =b.Subsidi,
                                  Promosi1  =b.Promosi,
                                  Komisi1  =b.Komisi,
                                  JoinPromo2  =b.JoinPromo1,
                                  JoinPromo1  =b.JoinPromo2,
                                  SPF1  =b.SPF,
                                  SellOut1  =b.SellOut,
                                  DendaWilayah1 = b.DendaWilayah,
                                  Tagihan1  = ((b.HargaOTR)-(b.UangMuka)),
                                  TotalTagihan1  = ((b.HargaOTR)-(b.UangMuka)+(b.JoinPromo1)),
                                  NamaLeasing  = h.NamaLease,
                                  CabangLeasing  =g.Cabang,
                                  NomorPO  =a.Keterangan,
                                  NoBuku1  =a.NoBuku,
                                  ProfitUnit  = ((d.Diskon)+(d.SellIn)+(b.JoinPromo1)+(b.JoinPromo2)+(b.SPF)-(b.DiskonKredit)-(b.DiskonTunai)-(b.Komisi)-(b.Promosi)-(b.SellOut))
    }

                   ).ToListAsync(cancellationToken);
            var model = new GetDataCekDPPenjualanViewModel
            {
                CekDPPenjualanDS = _mapper.Map<IEnumerable<GetDataCekDPPenjualanLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
