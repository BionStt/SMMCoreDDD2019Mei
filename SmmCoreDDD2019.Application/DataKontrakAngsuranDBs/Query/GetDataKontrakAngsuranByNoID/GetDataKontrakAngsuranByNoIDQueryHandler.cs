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

namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Query.GetDataKontrakAngsuranByNoID
{
    public class GetDataKontrakAngsuranByNoIDQueryHandler : IRequestHandler<GetDataKontrakAngsuranByNoIDQuery, GetDataKontrakAngsuranByNoIDViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetDataKontrakAngsuranByNoIDQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataKontrakAngsuranByNoIDViewModel> Handle(GetDataKontrakAngsuranByNoIDQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataKontrakAngsuran
                            join b in _context.DataKontrakKredit on a.NoRegisterKontrakKredit equals b.NoUrutDataKontrakKredit.ToString()
                            join c in _context.DataKontrakSurvei on b.NoRegisterSurvei equals c.NoUrutDataSurvei.ToString()
                            where b.NoUrutDataKontrakKredit == Int32.Parse(request.Id)
                      
                           select new
                           {
                               NoUrutDataKontrakKredit1 = b.NoUrutDataKontrakKredit,
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
