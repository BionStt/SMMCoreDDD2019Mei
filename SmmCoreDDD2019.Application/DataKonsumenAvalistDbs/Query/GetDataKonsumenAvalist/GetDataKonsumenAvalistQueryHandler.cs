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
namespace SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Query.GetDataKonsumenAvalist
{
    public class GetDataKonsumenAvalistQueryHandler : IRequestHandler<GetDataKonsumenAvalistQuery, GetDataKonsumenAvalistViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataKonsumenAvalistQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataKonsumenAvalistViewModel> Handle(GetDataKonsumenAvalistQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataKonsumenAvalist
                            where _context.DataKontrakSurvei.All(x=>x.DataKonsumenAvalistId != a.Id)
                           select new { NoCustomerAvalist = a.Id, NamaKonsumen = string.Format("{0} - {1} - {2}", a.NamaKonsumen, a.NamaPenjamin, a.NoHandphone) }

                ).OrderByDescending(x => x.NoCustomerAvalist).ToListAsync(cancellationToken);
            var model = new GetDataKonsumenAvalistViewModel
            {
                DataKonsumenAvalistDS = _mapper.Map<IEnumerable<GetDataKonsumenAvalistLookUpModel>>(aa)
            };
            return model;
            //return new GetCustomerDataPenjualanViewModel
            //{
            //    DataKonsumenDS = await _context.PembelianPO.ProjectTo<GetCustomerDataPenjualanLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
