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

namespace SmmCoreDDD2019.Application.Pembelians.Query.GetNamaPO
{
    public class GetNamaPOHandler : IRequestHandler<GetNamaPOQuery, GetNamaPOViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaPOHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaPOViewModel> Handle(GetNamaPOQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.PembelianPO
                           join b in _context.MasterSupplierDB on a.NoDealer equals b.IDSupplier
                           where a.Terinput == null
                           select new { NoUrutPoPembelian= a.NoUrutPo, NamaPOPembelian =string.Format("{0}  - {1:d} - {2}", a.NoUrutPo,a.TglPo, b.NamaSupplier) }
                
                ).ToListAsync(cancellationToken);
            var model = new GetNamaPOViewModel
            {
                DataPODS = _mapper.Map<IEnumerable<GetNamaPOLookUpModel>>(aa)
            };
            return model;
            //return new GetNamaPOViewModel
            //{
            //    DataPODS = await _context.PembelianPO.ProjectTo<GetNamaPOLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}