using MediatR;
using SumberMas2015.Inventory.Dto.MasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.MasterBarang.Queries.GetNamaBarangQrByNoUrut
{
    public class GetNamaBarangQrByNoUrutQuery:IRequest<GetNamaBarangQrByNoUrutResponse>
    {
        public string Id { get; set; }
    }
}
