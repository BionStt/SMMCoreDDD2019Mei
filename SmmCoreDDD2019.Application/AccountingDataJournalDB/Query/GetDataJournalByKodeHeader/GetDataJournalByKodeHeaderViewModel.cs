using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeHeader
{
    public class GetDataJournalByKodeHeaderViewModel
    {
        public IEnumerable<GetDataJournalByKodeHeaderLookUpModel> DataJournalByKodeHeaderDs { get; set; }
    }
}
