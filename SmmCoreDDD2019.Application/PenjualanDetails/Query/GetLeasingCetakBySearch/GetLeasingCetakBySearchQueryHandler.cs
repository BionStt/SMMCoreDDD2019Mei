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


namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetLeasingCetakBySearch
{
    public class GetLeasingCetakBySearchQueryHandler : IRequestHandler<GetLeasingCetakBySearchQuery, GetLeasingCetakBySearchViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetLeasingCetakBySearchQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetLeasingCetakBySearchViewModel> Handle(GetLeasingCetakBySearchQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.Penjualan
                            join b in _context.PenjualanDetail on a.KodePenjualan equals b.KodePenjualan
                            join c in _context.CustomerDB on a.KodeKonsumen equals c.CustomerID
                            join d in _context.StokUnit on b.NoUrutSO equals d.NoUrutSo
                            join e in _context.MasterBarangDB on d.KodeBrg equals e.NoUrutTypeKendaraan
                            where d.NoMesin.Contains(request.ID) || d.NoRangka.Contains(request.ID)
                            select new
                            {
                                NoUrutPenjualanDetail = b.NoPenjualanDetail,
                                TanggalPenjualan1 = a.TanggalPenjualan,
                                NamaKonsumen = string.Format("{0:d} - {1} - {2} - {3} - {4} - {5}", a.TanggalPenjualan, c.Nama, c.NamaBPKB, a.NoBuku, e.NamaBarang, d.NoMesin)

                            }

                  ).ToListAsync(cancellationToken);
            var model = new GetLeasingCetakBySearchViewModel
            {
                DataLeasingCetakDS = _mapper.Map<IEnumerable<GetLeasingCetakBySearchLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
