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

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKreditByNoID
{
    public class GetListDataKontrakKreditByNoIDQueryHandler : IRequestHandler<GetListDataKontrakKreditByNoIDQuery, GetListDataKontrakKreditByNoIDViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetListDataKontrakKreditByNoIDQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetListDataKontrakKreditByNoIDViewModel> Handle(GetListDataKontrakKreditByNoIDQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.DataKontrakAngsuran
                            join b in _context.DataKontrakKredit on a.DataKontrakKreditId equals b.Id
                            join c in _context.DataKontrakSurvei on b.DataKontrakSurveiId equals c.Id
                            join d in _context.DataKonsumenAvalist on c.DataKonsumenAvalistId equals d.Id
                            where b.Id == Int32.Parse(request.Id)

                            select new
                            {
                                NoUrutDataKontrakKredit1 = b.Id,
                                NamaKonsumen1 = d.NamaKonsumen,
                                NamaPenjamin1 = d.NamaPenjamin,
                                AlamatRumah = string.Format("{0} Kel.{1} Kec.{2} Kota {3} Propinsi {4} Kode Pos:{5}", d.AlamatTinggalK, d.KelurahanK, d.KecamatanK, d.KotaK, d.PropinsiK, d.KodePosTinggalK),
                                NoTeleponRumah = d.TelpRumah,
                                NoTeleponKantor = d.TelpKantor,
                                NoTeleponUsaha = d.TelpUsaha,
                                NoHP1 = d.NoHandphone,
                                NoHP2 = d.NoHandphone2,
                                NilaiKontrak1 = b.NilaiKontrak,
                                NilaiBunga1 = b.NilaiBunga,
                                Tenor1 = b.LamaKredit,
                                Angsuran1 = b.AngsuranBulanan,
                                pinjamanPokok = b.PinjamanPokok
                             
                            
                            }

              ).ToListAsync(cancellationToken);
            var model = new GetListDataKontrakKreditByNoIDViewModel
            {
                DataKontraKrediListByIDDs = _mapper.Map<IEnumerable<GetListDataKontrakKreditByNoIDLookUpModel>>(aa)
            };
            return model;
        }
    }
}
