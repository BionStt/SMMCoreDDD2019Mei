using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByDepth
{
    public class GetOrgChartByDepthViewModel
    {
        public IEnumerable<GetOrgChartByDepthLookUpModel> DataStructureByDepthDS { get; set; }
    }
}
