using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMasterBarangByID
{
    public class GetMasterBarangByIDViewModel
    {
        public IEnumerable<GetMasterBarangByIDLookUpModel> MasterBarangDs { get; set; }
    }
}
