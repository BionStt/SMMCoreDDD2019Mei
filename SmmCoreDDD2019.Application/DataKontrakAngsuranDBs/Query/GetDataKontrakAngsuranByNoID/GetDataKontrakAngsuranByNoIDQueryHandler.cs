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

namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Query.GetDataKontrakAngsuranByNoID
{
    public class GetDataKontrakAngsuranByNoIDQueryHandler : IRequestHandler<GetDataKontrakAngsuranByNoIDQuery, GetDataKontrakAngsuranByNoIDViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataKontrakAngsuranByNoIDQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataKontrakAngsuranByNoIDViewModel> Handle(GetDataKontrakAngsuranByNoIDQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataKontrakAngsuran
                            join b in _context.DataKontrakKredit on a.DataKontrakKreditId equals b.Id
                            join c in _context.DataKontrakSurvei on b.DataKontrakSurveiId equals c.Id
                            where b.Id == Int32.Parse(request.Id)
                      
                           select new
                           {
                               NoUrutDataKontrakKredit1 = b.Id,
                               AngsuranKeA = a.AngsuranKe,
                               TanggalAngsuran1= a.TanggalAngsuran,
                               AngsuranPerBulan= a.Angsuran,
                               Pokok1 = a.Pokok,
                               Bunga1=a.Bunga,
                               SisaPokok1=a.SisaPokok,
                               SisaBunga1=a.SisaBunga
                            }

             ).OrderBy(x=>x.AngsuranKeA).ToListAsync(cancellationToken);
            var model = new GetDataKontrakAngsuranByNoIDViewModel
            {
                DataKontrakAngsuranDs = _mapper.Map<IEnumerable<GetDataKontrakAngsuranByNoIDLookUpModel>>(aa)
            };
            return model;
        }
    }
}
