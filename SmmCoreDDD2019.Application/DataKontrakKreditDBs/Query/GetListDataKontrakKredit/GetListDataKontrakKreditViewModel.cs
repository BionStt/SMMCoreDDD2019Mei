using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKredit
{
    public class GetListDataKontrakKreditViewModel
    {
        public IEnumerable<GetListDataKontrakKreditLookUpModel> DataKontraKrediListDs { get; set; }
    }
}
