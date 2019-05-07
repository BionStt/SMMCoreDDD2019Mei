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
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeAkun
{
    public class GetDataJournalByKodeAkunQueryHandler : IRequestHandler<GetDataJournalByKodeAkunQuery, GetDataJournalByKodeAkunViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataJournalByKodeAkunQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataJournalByKodeAkunViewModel> Handle(GetDataJournalByKodeAkunQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.AccountingDataAccount
                            join b in _context.AccountingDataJournal on a.NoUrutAccountId equals Int32.Parse(b.NoUrutAccountId)
                           join c in _context.AccountingDataJournalHeader on b.NoUrutJournalH equals c.NoUrutJournalH.ToString()
                           where  b.NoUrutAccountId == request.Id
                      
                           select new
                           {
                               NoUrutAccountId = a.NoUrutAccountId,
                               NoUrutJournalHeaderId = c.NoUrutJournalH,
                               DataAkun = a.KodeAccount + " - " + a.Account,
                               Debit1 = b.Debit,
                               Kredit1 = b.Kredit,
                               Ket1 = b.Keterangan,
                               TanggalInput= c.TanggalInput,
                               NoBuktiJurnal=c.NoBuktiJournal
                           }).ToListAsync(cancellationToken);
            var model = new GetDataJournalByKodeAkunViewModel
            {
                DataJournalByKodeAkunDs = _mapper.Map<IEnumerable<GetDataJournalByKodeAkunLookUpModel>>(aa)
            };
            return model;
        }
    }
}
