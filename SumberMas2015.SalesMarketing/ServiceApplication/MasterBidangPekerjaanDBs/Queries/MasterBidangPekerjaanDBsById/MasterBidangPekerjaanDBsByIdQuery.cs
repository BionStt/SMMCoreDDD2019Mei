using MediatR;
using SumberMas2015.SalesMarketing.Dto.MasterBidangPekerjaanDBs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries.MasterBidangPekerjaanDBsById
{
    public class MasterBidangPekerjaanDBsByIdQuery:IRequest<MasterBidangPekerjaanDBsByIdResponse>
    {
        public int NoUrutId { get; set; }
    }
}
