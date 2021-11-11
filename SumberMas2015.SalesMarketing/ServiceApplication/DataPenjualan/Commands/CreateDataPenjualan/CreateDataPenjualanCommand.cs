using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Commands.CreateDataPenjualan
{
    public class CreateDataPenjualanCommand:IRequest<Guid>
    {
        public int dataSPKId { get; set; }
        public int dataKonsumenId { get; set; }
        public int masterLeasingCabangId { get; set; }
        public string noBuku { get; set; }
        public int salesUserId { get; set; }
        public string keterangan { get; set; }
        public int masterKategoriPenjualanId { get; set; }
        public string mediator { get; set; }
        public string UserName{ get; set; }
        public Guid UserNameId { get; set; }
    }
}
