using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Query.GetDataKontrakAngsuranByNoID
{
    public class GetDataKontrakAngsuranByNoIDQuery : IRequest<GetDataKontrakAngsuranByNoIDViewModel>
    {
        public string Id { get; set; }
    }
}
