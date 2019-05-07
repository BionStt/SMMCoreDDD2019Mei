using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivotCabangLeasing
{
    public class GetLaporanPenjualanPivotCabangLeasingQuery : IRequest<GetLaporanPenjualanPivotCabangLeasingViewModel>
    {
        public DateTime PeriodeAwal { get; set; }
        public DateTime PeriodeAkhir { get; set; }
    }
}

