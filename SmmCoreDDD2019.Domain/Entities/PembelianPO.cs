using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class PembelianPO : BaseEntity
    {
      //  public int NoUrutPo { get; set; }
      
      public DateTime? TglPo { get; set; }
      public int? MasterSupplierDBId { get; set; }
   public string NoRegistrasiPoPMB { get; set; }
        public string Keterangan { get; set; }
        public string Terinput { get; set; }
        public int? UserId { get; set; }
        public string UserInput { get; set; }
        public string PoAstra { get; set; }

        public Pembelian Pembelian { get; set; }
    }
}
