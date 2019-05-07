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

namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetKodeBeliDetail
{
    public class GetKodeBeliDetailQueryHandler : IRequestHandler<GetKodeBeliDetailQuery, GetKodeBeliDetailViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetKodeBeliDetailQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetKodeBeliDetailViewModel> Handle(GetKodeBeliDetailQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.PembelianDetail
                            join b in _context.MasterBarangDB on a.KodeBrg equals b.NoUrutTypeKendaraan
                            where a.KodeBeliDetail == Int32.Parse(request.Id)
                            //   where a.Terinput == null
                            select new { NoKodeBeli1=a.KodeBeli, NoKodeBeliDetail = a.KodeBeliDetail, KodeBarang=b.NoUrutTypeKendaraan, HargaOff=b.Harga, Diskon1=a.Diskon, SellIn1=a.SellIn, NamaBarang1 = string.Format("{0} - {1} - {2}", b.TypeKendaraan, b.NamaBarang,b.Merek) }

               ).ToListAsync(cancellationToken);
            var model = new GetKodeBeliDetailViewModel
            {
                DataPembelianDetailDS = _mapper.Map<IEnumerable<GetKodeBeliDetailLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliDetailViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliDetailLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
