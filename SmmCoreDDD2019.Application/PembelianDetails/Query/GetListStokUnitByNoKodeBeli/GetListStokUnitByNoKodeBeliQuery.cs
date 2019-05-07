using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetListStokUnitByNoKodeBeli
{
    public class GetListStokUnitByNoKodeBeliQuery : IRequest<GetListStokUnitByNoKodeBeliViewModel>
    {
        public string Id { get; set; }
    }
}
