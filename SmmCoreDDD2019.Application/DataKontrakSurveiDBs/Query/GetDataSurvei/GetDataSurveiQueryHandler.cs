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

namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Query.GetDataSurvei
{
    public class GetDataSurveiQueryHandler : IRequestHandler<GetDataSurveiQuery, GetDataSurveiViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataSurveiQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataSurveiViewModel> Handle(GetDataSurveiQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataKontrakSurvei
                            join b in _context.DataKonsumenAvalist on a.DataKonsumenAvalistId equals b.Id
                            where _context.DataKontrakKredit.All(x => x.DataKontrakSurveiId != a.Id)
                            select new { NoDataSurveiAvalist = a.Id, NamaKonsumen = string.Format("{0} - {1} - {2}", b.NoRegisterKonsumen, b.NamaKonsumen, b.NamaPenjamin) }

                ).OrderByDescending(x => x.NoDataSurveiAvalist).ToListAsync(cancellationToken);
            var model = new GetDataSurveiViewModel
            {
                DataSurveiAvalistDS = _mapper.Map<IEnumerable<GetDataSurveilookUpModel>>(aa)
            };
            return model;
            //return new GetCustomerDataPenjualanViewModel
            //{
            //    DataKonsumenDS = await _context.PembelianPO.ProjectTo<GetCustomerDataPenjualanLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
