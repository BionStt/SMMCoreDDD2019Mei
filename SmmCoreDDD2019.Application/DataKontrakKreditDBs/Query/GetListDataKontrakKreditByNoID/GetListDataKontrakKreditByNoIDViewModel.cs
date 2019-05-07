using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKreditByNoID
{
    public class GetListDataKontrakKreditByNoIDViewModel
    {
        public IEnumerable<GetListDataKontrakKreditByNoIDLookUpModel> DataKontraKrediListByIDDs { get; set; }
    }
}
