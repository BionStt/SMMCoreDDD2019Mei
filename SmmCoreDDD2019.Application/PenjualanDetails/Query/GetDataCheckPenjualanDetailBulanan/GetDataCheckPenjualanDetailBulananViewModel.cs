using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanDetailBulanan
{
    public class GetDataCheckPenjualanDetailBulananViewModel
    {
        public IEnumerable<GetDataCheckPenjualanDetailBulananLookUpModel> GetDataPenjualanDetailByNosinDS { get; set; }
    }
}
