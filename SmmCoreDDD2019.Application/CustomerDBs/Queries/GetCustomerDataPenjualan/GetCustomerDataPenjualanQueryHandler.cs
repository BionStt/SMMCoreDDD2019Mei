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
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDataPenjualan
{
    public class GetCustomerDataPenjualanQueryHandler : IRequestHandler<GetCustomerDataPenjualanQuery, GetCustomerDataPenjualanViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetCustomerDataPenjualanQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetCustomerDataPenjualanViewModel> Handle(GetCustomerDataPenjualanQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.CustomerDB
                           where a.Jual==null
                      select new { NoCustomer=a.Id, NamaKonsumen = string.Format("{0} - {1} - {2}",a.Nama,a.NamaBPKB,a.Handphone) }

                ).OrderByDescending(x=>x.NoCustomer).ToListAsync(cancellationToken);
            var model = new GetCustomerDataPenjualanViewModel
            {
                DataKonsumenDS = _mapper.Map<IEnumerable<GetCustomerDataPenjualanLookUpModel>>(aa)
            };
            return model;
            //return new GetCustomerDataPenjualanViewModel
            //{
            //    DataKonsumenDS = await _context.PembelianPO.ProjectTo<GetCustomerDataPenjualanLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
