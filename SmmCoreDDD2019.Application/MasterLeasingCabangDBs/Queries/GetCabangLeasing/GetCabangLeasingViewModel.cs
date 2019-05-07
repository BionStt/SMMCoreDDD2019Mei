using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Queries.GetCabangLeasing
{
    public class GetCabangLeasingViewModel
    {
        public IEnumerable<GetCabangLeasingLookUpModel> MasterLeasingCabangDs { get; set; }
      //  public IList<GetCabangLeasingLookUpModel> MasterLeasingCabangDs { get; set; }
    }
}
