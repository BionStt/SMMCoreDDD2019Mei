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
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalAll
{
  
    public class GetDataJournalAllQueryHandler : IRequestHandler<GetDataJournalAllQuery, GetDataJournalAllViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataJournalAllQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataJournalAllViewModel> Handle(GetDataJournalAllQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.AccountingDataJournal
                            join b in _context.AccountingDataAccount on a.AccountingDataAccountId equals b.Id into ps
                            from b in ps.DefaultIfEmpty()
                            join c in _context.AccountingDataJournalHeader on a.AccountingDataJournalHeaderId equals c.Id
                        
                            select new
                            {
                                AccountingDataAccountId = b.Id,
                                AccountingDataJournalIdH = c.Id,
                                DataAkun = b.KodeAccount + " - " + b.Account,
                                Debit1 = a.Debit,
                                Kredit1 = a.Kredit,
                                Ket1 = a.Keterangan,
                                TanggalInput = c.TanggalInput,
                                NoBuktiJurnal = c.NoBuktiJournal
                            }).ToListAsync(cancellationToken);
            var model = new GetDataJournalAllViewModel
            {
                DataJournalAllDs = _mapper.Map<IEnumerable<GetDataJournalAllLookUpModel>>(aa)
            };
            return model;
        }
    }
}
