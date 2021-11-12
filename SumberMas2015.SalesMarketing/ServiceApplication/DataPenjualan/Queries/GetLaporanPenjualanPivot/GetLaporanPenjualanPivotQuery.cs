using MediatR;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivot
{
    public class GetLaporanPenjualanPivotQuery:IRequest<IReadOnlyCollection<GetLaporanPenjualanPivotResponse>>
    {
        public DateTime PeriodeAwal { get; set; }
        public DateTime PeriodeAkhir { get; set; }

    }
}
