using MediatR;
using SumberMas2015.SalesMarketing.Dto.MasterKategoriPenjualan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.Queries.ListKategoriPenjualan
{
    public class ListKategoriPenjualanQuery:IRequest<IReadOnlyCollection<ListKategoriPenjualanResponse>>
    {

    }
}
