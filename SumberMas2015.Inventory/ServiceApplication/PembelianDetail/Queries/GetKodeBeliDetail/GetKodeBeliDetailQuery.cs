using MediatR;
using SumberMas2015.Inventory.Dto.PembelianDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Queries.GetKodeBeliDetail
{
    public class GetKodeBeliDetailQuery:IRequest<GetKodeBeliDetailResponse>
    {
        public string Id { get; set; }
    }
}
