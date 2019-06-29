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

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKredit
{
    public class GetListDataKontrakKreditQueryHandler : IRequestHandler<GetListDataKontrakKreditQuery, GetListDataKontrakKreditViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetListDataKontrakKreditQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetListDataKontrakKreditViewModel> Handle(GetListDataKontrakKreditQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataKontrakKredit
                            join b in _context.DataKontrakSurvei on a.DataKontrakSurveiId equals b.Id
                            join c in _context.DataKonsumenAvalist on b.DataKonsumenAvalistId equals c.Id
                            join d in _context.MasterBarangDB on b.MasterBarangDBId equals d.Id
                            select new
                            {
                                NoUrutDataKontrakKredit1 = a.Id,
                                DataKontrakKredit = string.Format("{0} - {1} - {2} - {3}", a.NoRegisterKontrakKredit, c.NamaKonsumen, c.NamaPenjamin, d.NamaBarang) }

            ).OrderByDescending(x=>x.NoUrutDataKontrakKredit1).ToListAsync(cancellationToken);
            var model = new GetListDataKontrakKreditViewModel
            {
                DataKontraKrediListDs = _mapper.Map<IEnumerable<GetListDataKontrakKreditLookUpModel>>(aa)
            };
            return model;
        }
    }
}
