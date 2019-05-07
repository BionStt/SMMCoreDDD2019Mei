using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanNeraca
{
    public class GetLaporanNeracaViewModel
    {
        public IEnumerable<GetLaporanNeracaLookUpModel> LaporanNeracaDS { get; set; }
    }
}
