using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Queries.GetDataKendaraanByNoSPK
{
    public class GetDataKendaraanByNoSPKQuery : IRequest<GetDataKendaraanByNoSPKViewModel>
    {
        public string Id { get; set; }
    }
}
