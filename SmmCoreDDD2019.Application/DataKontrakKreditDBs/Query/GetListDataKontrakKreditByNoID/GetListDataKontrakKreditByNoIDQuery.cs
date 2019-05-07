using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKreditByNoID
{
    public class GetListDataKontrakKreditByNoIDQuery : IRequest<GetListDataKontrakKreditByNoIDViewModel>
    {
        public string Id { get; set; }
    }
}
