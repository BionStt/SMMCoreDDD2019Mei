using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent
{
    public class GetDataAccountByParentViewModel
    {
        public IEnumerable<GetDataAccountByParentLookUpModel> DataAccountParentDs { get; set; }
    }
}
