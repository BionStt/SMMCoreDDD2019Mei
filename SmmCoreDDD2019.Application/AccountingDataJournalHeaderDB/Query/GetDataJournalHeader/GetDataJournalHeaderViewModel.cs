using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Query.GetDataJournalHeader
{
    public class GetDataJournalHeaderViewModel
    {
        public IEnumerable<GetDataJournalHeaderLookUpModel> DataJournalHeaderDs { get; set; }
    }
}
