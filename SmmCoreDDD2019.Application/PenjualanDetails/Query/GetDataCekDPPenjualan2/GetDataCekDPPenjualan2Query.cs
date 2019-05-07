using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPPenjualan2
{
    public class GetDataCekDPPenjualan2Query : IRequest<GetDataCekDPPenjualan2ViewModel>
    {
        public string IDLeasingCabang { get; set; }
        public DateTime TanggalPenjualan1 { get; set; }
        public DateTime TanggalPenjualan2 { get; set; }
        public DateTime TanggalPenjualan1a { get; set; }
        public DateTime TanggalPenjualan2a { get; set; }
    }
}
