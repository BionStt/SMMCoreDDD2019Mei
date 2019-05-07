using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByParent2
{
    public class GetStructureByParent2Query:IRequest<GetStructureByParent2ViewModel>
    {
        public string Id { get; set; }
    }
}
