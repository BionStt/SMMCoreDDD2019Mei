using MediatR;
using SumberMas2015.SalesMarketing.Dto.DataSPK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.DataSPKById
{
    public class DataSPKByIdQuery:IRequest<DataSPKByIdResponse>
    {
        public int DataSPKId { get; set; }
    }
}
