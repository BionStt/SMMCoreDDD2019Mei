using MediatR;
using SumberMas2015.SalesMarketing.Dto.MasterKategoriCaraPembayaran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriCaraPembayaran.Queries.ListKategoriCaraPembayaran
{
    public class ListKategoriCaraPembayaranQuery:IRequest<IReadOnlyCollection<ListKategoriCaraPembayaranResponse>>
    {

    }
}
