using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.StokUnits.Query.GetDataSO
{
    public class GetDataSOQueryHandler : IRequestHandler<GetDataSOQuery, GetDataSOViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataSOQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataSOViewModel> Handle(GetDataSOQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.StokUnit
                            join b in _context.MasterBarangDB on a.KodeBrg equals b.NoUrutTypeKendaraan
                            //   where a.Terinput == null
                            select new { NoUrutSO = a.NoUrutSo, NamaBarang = string.Format("{0} - {1} - {2} - {3} - {4} - {5:c}", a.NoMesin, a.NoRangka, a.Warna,b.NamaBarang,b.Merek,b.Harga+b.BBN) }

               ).ToListAsync(cancellationToken);
            var model = new GetDataSOViewModel
            {
                DataSODs = _mapper.Map<IEnumerable<GetDataSOLookUpModel>>(aa)
            };
            return model;
            //return new GetDataSOViewModel
            //{
            //    DataSODs = await _context.PembelianPO.ProjectTo<GetDataSOLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
