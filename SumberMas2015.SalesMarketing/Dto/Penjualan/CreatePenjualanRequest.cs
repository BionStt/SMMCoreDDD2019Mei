using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.Penjualan
{
    public class CreatePenjualanRequest
    {
        public int DataSPKId { get;  set; }
        public int DataKonsumenId { get;  set; }
        public int MasterLeasingCabang { get;  set; }
        public string NoBuku { get;  set; }
        public string Keterangan { get;  set; }
        public int NamaSales { get; set; }
        public int MasterKategoriPenjualan { get;  set; }
        public string UserNameInput { get;  set; }
        public string Mediator { get;  set; }
        public DateTime TanggalPenjualan { get; set; }

    }
}
