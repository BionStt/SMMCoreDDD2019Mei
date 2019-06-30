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
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanBulanan
{
    public class GetDataCheckPenjualanBulananQueryHandler : IRequestHandler<GetDataCheckPenjualanBulananQuery, GetDataCheckPenjualanBulananViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataCheckPenjualanBulananQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataCheckPenjualanBulananViewModel> Handle(GetDataCheckPenjualanBulananQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.Penjualan
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
                           join m in _context.PermohonanFakturDB on b.Id equals m.PenjualanDetailId
                           //  join n in _context.PenjualanPiutang on b.NoPenjualanDetail equals n.KodePenjualanDetail
                           let DataPj = c.Nama + " - " + a.NoBuku + " - " + a.TanggalPenjualan + " - " + h.NamaLease + " - " + g.Cabang
                           where b.CheckLapBulanan==null && ((a.TanggalPenjualan.Value <= request.TanggalPenjualan2 && a.TanggalPenjualan.Value >= request.TanggalPenjualan1) || (a.TanggalPenjualan.Value <= request.TanggalPenjualan2a && a.TanggalPenjualan.Value >= request.TanggalPenjualan1a)) 
                           select new
                           {
                               NoUrutPenjualanDetail = b.Id,
                               DataPenjualan = DataPj,
                               TanggalPenjualan = a.TanggalPenjualan,
                               CheckDP = b.CheckDp,
                               KodePenjualan = a.Id

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
