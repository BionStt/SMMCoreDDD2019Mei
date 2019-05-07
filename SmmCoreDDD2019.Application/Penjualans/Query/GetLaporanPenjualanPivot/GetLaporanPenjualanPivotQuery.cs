using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivot
{
    public class GetLaporanPenjualanPivotQuery : IRequest<GetLaporanPenjualanPivotViewModel>
    {
        public DateTime PeriodeAwal { get; set; }
        public DateTime PeriodeAkhir { get; set; }
    }
}
