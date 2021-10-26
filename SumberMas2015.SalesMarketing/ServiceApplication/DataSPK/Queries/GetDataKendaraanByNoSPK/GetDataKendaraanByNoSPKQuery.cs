using MediatR;
using SumberMas2015.SalesMarketing.Dto.DataSPK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.GetDataKendaraanByNoSPK
{
    public class GetDataKendaraanByNoSPKQuery:IRequest<GetDataKendaraanByNoSPKResponse>
    {
        public string Id { get; set; }
    }
}
