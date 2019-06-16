using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading;


namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Queries.GetNamaSPK
{
    public class GetNamaSPKQueryHandler : IRequestHandler<GetNamaSPKQuery, GetNamaSPKViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaSPKQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaSPKViewModel> Handle(GetNamaSPKQuery request, CancellationToken cancellationToken)
        {
            //var aa = await (from a in _context.DataSPKBaruDB
            //                join b in _context.DataSPKSurveiDB on a.NoUrutSPKBaru equals b.NoUrutSPKBaru
            //                join c in _context.DataSPKKendaraanDB on a.NoUrutSPKBaru equals c.NoUrutSPKBaru
            //                join d in _context.MasterBarangDB on c.NoUrutTypeKendaraan equals d.NoUrutTypeKendaraan
            //                join e in _context.DataSPKKreditDB on a.NoUrutSPKBaru equals e.NoUrutSPKBaru
            //                //   where a.Terinput == null
            //                select new { NoUrutSPKBaru1 = a.NoUrutSPKBaru, NamaPemesan = string.Format("{0} - {1} - {2} - {3}", b.NamaPemesan, b.HandphonePemesan, d.NamaBarang,e.DPPriceList) }

            // ).ToListAsync(cancellationToken);
            //var model = new GetNamaSPKViewModel
            //{
            //    DataSPkPemesanDs = _mapper.Map<IEnumerable<GetNamaSPKlookUpModel>>(aa)
            //};
            //return model;


            return new GetNamaSPKViewModel
            {
                DataSPkPemesanDs = await _context.DataSPKSurveiDB.ProjectTo<GetNamaSPKlookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };

        }
    }
}
