﻿using System;
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
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivotCabangLeasing
{
    public class GetLaporanPenjualanPivotCabangLeasingQueryHandler : IRequestHandler<GetLaporanPenjualanPivotCabangLeasingQuery, GetLaporanPenjualanPivotCabangLeasingViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetLaporanPenjualanPivotCabangLeasingQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetLaporanPenjualanPivotCabangLeasingViewModel> Handle(GetLaporanPenjualanPivotCabangLeasingQuery request, CancellationToken cancellationToken)
        {
            //            SELECT Nama,[HONDA] as HONDA,[YAMAHA] as YAMAHA,[SUZUKI] as SUZUKI,[KAWASAKI] as KAWASAKI , [HONDA]+[YAMAHA]+[SUZUKI]+[KAWASAKI]as TOtalRow
            //from
            //(SELECT dbo.NamaLease.Nama, dbo.NamaLease.cabang, dbo.MasterBrg.Merek, dbo.StokUnit.NoMesin
            //FROM            dbo.PenjualanDetail INNER JOIN
            //dbo.Penjualan ON dbo.PenjualanDetail.KodePj = dbo.Penjualan.KodePj INNER JOIN

            //dbo.NamaLease ON dbo.Penjualan.KdLease = dbo.NamaLease.IDLease INNER JOIN

            //dbo.StokUnit ON dbo.PenjualanDetail.KodeSO = dbo.StokUnit.NoUrutSO INNER JOIN

            //dbo.MasterBrg ON dbo.StokUnit.KodeBrg = dbo.MasterBrg.NoUrut
            //WHERE        (dbo.Penjualan.TglPj BETWEEN CONVERT(DATETIME, '2018-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2018-12-31 00:00:00', 102)) 
            //) p
            //PIVOT
            //(
            //Count (NoMesin)
            //for Merek IN
            //(
            //[HONDA],[YAMAHA],[SUZUKI],[KAWASAKI]
            //)
            //)as PVT
            //order by PVT.Nama





            var bb = await (from a in _context.PenjualanDetail
                            join b in _context.StokUnit on a.NoUrutSO equals b.NoUrutSo
                            join c in _context.MasterBarangDB on b.KodeBrg equals c.NoUrutTypeKendaraan
                            join d in _context.Penjualan on a.KodePenjualan equals d.KodePenjualan
                            join e in _context.MasterLeasingCabangDB on d.KodeLease equals e.NoUrutLeasingCabang
                            join f in _context.MasterLeasingDb on e.IDlease equals f.IDlease
                            where (d.TanggalPenjualan <= request.PeriodeAkhir && d.TanggalPenjualan >= request.PeriodeAwal)
                            select new
                            {
                                NamaLeasing = f.NamaLease,
                                CabangLeasing = e.Cabang,
                                Merek = c.Merek,
                                NoMesin = b.NoMesin
                            }
                       ).ToListAsync(cancellationToken);

            var aa = (from a in bb
                      group a by new { a.NamaLeasing, a.CabangLeasing }
                           into BiongGroup
                      where BiongGroup.Count() > 0
                      select new
                      {
                          NamaLeasing = BiongGroup.Key.NamaLeasing,
                          CabangLeasing = BiongGroup.Key.CabangLeasing,
                          SUZUKI = BiongGroup.Where(a => a.Merek == "SUZUKI").Count(),
                          YAMAHA = BiongGroup.Where(a => a.Merek == "YAMAHA").Count(),
                          KAWASAKI = BiongGroup.Where(a => a.Merek == "KAWASAKI").Count(),
                          HONDA = BiongGroup.Where(a => a.Merek == "HONDA").Count(),
                          TtlRow = BiongGroup.Count()
                      }
            ).ToList();
            var model = new GetLaporanPenjualanPivotCabangLeasingViewModel
            {
                DataPenjualanPivotCabangLeasingDS = _mapper.Map<IEnumerable<GetLaporanPenjualanPivotCabangLeasingLookUpModel>>(aa)
            };
            return model;
        }
    }
}