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
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeHeader
{
    public class GetDataJournalByKodeHeaderQueryHandler : IRequestHandler<GetDataJournalByKodeHeaderQuery, GetDataJournalByKodeHeaderViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataJournalByKodeHeaderQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataJournalByKodeHeaderViewModel> Handle(GetDataJournalByKodeHeaderQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.AccountingDataJournal 
                            join b in _context.AccountingDataAccount on  a.AccountingDataAccountId equals b.Id
                            where a.AccountingDataJournalHeaderId ==request.Id
                           
                            select new
                            {
                                NoUrutAccountId =b.Id ,
                                NoUrutJournalHeaderId = a.AccountingDataJournalHeaderId,
                                DataAkun = b.KodeAccount + " - " + b.Account,
                                Debit1 = a.Debit,
                                Kredit1 = a.Kredit,
                                Ket1 = a.Keterangan
                              
                            }).ToListAsync(cancellationToken);
            var model = new GetDataJournalByKodeHeaderViewModel
            {
                DataJournalByKodeHeaderDs = _mapper.Map<IEnumerable<GetDataJournalByKodeHeaderLookUpModel>>(aa)
            };
            return model;
        }
    }
}
