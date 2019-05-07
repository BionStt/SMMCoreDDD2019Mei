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
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Queries.GetDataKendaraanByNoSPK
{
    public class GetDataKendaraanByNoSPKQueryHandler : IRequestHandler<GetDataKendaraanByNoSPKQuery, GetDataKendaraanByNoSPKViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataKendaraanByNoSPKQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataKendaraanByNoSPKViewModel> Handle(GetDataKendaraanByNoSPKQuery request, CancellationToken cancellationToken)
        {
            //return new GetDataKendaraanByNoSPKViewModel
            //{
            //    DataKendaraanByNoSPKDs = await _context.MasterBarangDB.ProjectTo<GetDataKendaraanByNoSPKLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};

           var dataKendaraan = await (from a in _context.DataSPKBaruDB
                                      join c in _context.DataSPKKendaraanDB on a.NoUrutSPKBaru equals c.NoUrutSPKBaru
                                       join b in _context.MasterBarangDB on c.NoUrutTypeKendaraan equals b.NoUrutTypeKendaraan
                                        where a.NoUrutSPKBaru ==Int32.Parse(request.Id)
                                       select new { HargaOff=b.Harga, BBN=b.BBN }
                ).ToListAsync(cancellationToken);

            if (dataKendaraan == null)
            {
                throw new NotFoundException(nameof(DataSPKKendaraanDB), request.Id);
            }

            var model = new GetDataKendaraanByNoSPKViewModel
            {
                DataKendaraanByNoSPKDs = _mapper.Map<IEnumerable<GetDataKendaraanByNoSPKLookUpModel>>(dataKendaraan)
            };
            return model;
        }
    }
}
