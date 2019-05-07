using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalAll
{
    public class GetDataJournalAllViewModel
    {
        public IEnumerable<GetDataJournalAllLookUpModel> DataJournalAllDs { get; set; }
    }
}
