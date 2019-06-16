using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByParent
{
    public class GetStructureByParentViewModel
    {
        public IEnumerable<GetStructureByParentLookUpModel> StructureDataParentDs { get; set; }
       //public IList<GetStructureByParentLookUpModel> StructureDataParentDs { get; set; }
    }
}
