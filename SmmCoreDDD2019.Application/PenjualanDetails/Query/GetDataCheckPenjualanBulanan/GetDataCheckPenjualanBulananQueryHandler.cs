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
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanBulanan
{
    public class GetDataCheckPenjualanBulananQueryHandler : IRequestHandler<GetDataCheckPenjualanBulananQuery, GetDataCheckPenjualanBulananViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataCheckPenjualanBulananQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataCheckPenjualanBulananViewModel> Handle(GetDataCheckPenjualanBulananQuery request, CancellationToken cancellationToken)
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
                           join m in _context.PermohonanFakturDB on b.NoPenjualanDetail equals m.KodePenjualanDetail
                           //  join n in _context.PenjualanPiutang on b.NoPenjualanDetail equals n.KodePenjualanDetail
                           let DataPj = c.Nama + " - " + a.NoBuku + " - " + a.TanggalPenjualan + " - " + h.NamaLease + " - " + g.Cabang
                           where b.CheckLapBulanan==null && ((a.TanggalPenjualan.Value <= request.TanggalPenjualan2 && a.TanggalPenjualan.Value >= request.TanggalPenjualan1) || (a.TanggalPenjualan.Value <= request.TanggalPenjualan2a && a.TanggalPenjualan.Value >= request.TanggalPenjualan1a)) 
                           select new
                           {
                               NoUrutPenjualanDetail = b.NoPenjualanDetail,
                               DataPenjualan = DataPj,
                               TanggalPenjualan = a.TanggalPenjualan,
                               CheckDP = b.CheckDp,
                               KodePenjualan = a.KodePenjualan

                           }).ToListAsync(cancellationToken);
            var model = new GetDataCheckPenjualanBulananViewModel
            {
                CheckPenjualanBulananDs = _mapper.Map<IEnumerable<GetDataCheckPenjualanBulananLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
