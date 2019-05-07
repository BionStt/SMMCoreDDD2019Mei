using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMerek
{
    public class GetMerekViewModel
    {
        public IEnumerable<GetMerekLookUpModel> MasterBarangMerekDs { get; set; }
    }
}
