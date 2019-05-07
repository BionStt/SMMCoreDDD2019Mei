using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPBulanan
{
    public class GetDataCekDPBulananQuery : IRequest<GetDataCekDPBulananViewModel>
    {
     //   public string IDLeasingCabang { get; set; }
        public DateTime TanggalPenjualan1 { get; set; }
        public DateTime TanggalPenjualan2 { get; set; }
        public DateTime TanggalPenjualan1a { get; set; }
        public DateTime TanggalPenjualan2a { get; set; }
    }
}
