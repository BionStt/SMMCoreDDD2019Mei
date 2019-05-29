using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.AccountingTipeJournalDB.Query.GetTipeJournal
{
    public class GetTipeJournalQueryHandler : IRequestHandler<GetTipeJournalQuery, GetTipeJournalViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetTipeJournalQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetTipeJournalViewModel> Handle(GetTipeJournalQuery request, CancellationToken cancellationToken)
        {

            return new GetTipeJournalViewModel
            {
                DataTipeJournalDs = await _context.MasterLeasingDb.ProjectTo<GetTipeJournalLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };



            //var aa = await(from a in _context.AccountingDataAccount
            //               orderby a.KodeAccount
            //               where (a.Parent == null)
            //               select new
            //               {
            //                   NoUrutAccountId = a.NoUrutAccountId,
            //                   DataAkun = "[" + a.KodeAccount + "] - " + a.Account + " - " + Analyze(a.Kelompok) + " - " + NormalPos(a.NormalPos)


            //               }).ToListAsync(cancellationToken);
            //var model = new GetDataAccountByParentViewModel
            //{
            //    DataAccountParentDs = _mapper.Map<IEnumerable<GetDataAccountByParentLookUpModel>>(aa)
            //};
            //return model;
        }
    }
}
