using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByParent2
{
    public class GetStructureByParent2Query : IRequest<GetStructureByParent2ViewModel>
    {
        public string Id { get; set; }
    }
}
