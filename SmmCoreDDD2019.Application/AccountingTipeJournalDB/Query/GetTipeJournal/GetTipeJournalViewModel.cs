﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.AccountingTipeJournalDB.Query.GetTipeJournal
{
    public class GetTipeJournalViewModel
    {
        public IEnumerable<GetTipeJournalLookUpModel> DataTipeJournalDs { get; set; }
    }
}