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
        public Guid dataSPKId { get; set; }
        public Guid dataKonsumenId { get; set; }
        public Guid masterLeasingCabangId { get; set; }
        public string noBuku { get; set; }
        public int salesUserId { get; set; }
        public string keterangan { get; set; }
        public Guid masterKategoriPenjualanId { get; set; }
        public string mediator { get; set; }
        public string userNameInput { get; set; }
    }
}
