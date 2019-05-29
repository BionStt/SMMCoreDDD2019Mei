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

namespace SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Query.GetDataJournalHeader
{
    public class GetDataJournalHeaderQueryHandler : IRequestHandler<GetDataJournalHeaderQuery, GetDataJournalHeaderViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataJournalHeaderQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataJournalHeaderViewModel> Handle(GetDataJournalHeaderQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.AccountingDataJournalHeader
                            select new
                           {
                                NoUrutJournalHID = a.NoUrutJournalH,
                                DataJournalHeaders = string.Format("{0:d}", a.TanggalInput) +" - "+ a.NoBuktiJournal + " - " + a.Keterangan     
                                
                            }).ToListAsync(cancellationToken);
            var model = new GetDataJournalHeaderViewModel
            {
                DataJournalHeaderDs = _mapper.Map<IEnumerable<GetDataJournalHeaderLookUpModel>>(aa)
            };
            return model;
        }
    }
}
