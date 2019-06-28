using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class Penjualan : BaseEntity
    {
      
       // public int KodePenjualan { get; set; }
        public string NoRegistrasiPenjualan { get; set; }

        public int? DataSPKBaruDBId { get; set; }
        public DateTime? TanggalPenjualan { get; set; }
     
        public int? CustomerDBId { get; set; }
      
        public int? MasterLeasingCabangDBId { get; set; }
     
        public string NoBuku { get; set; }
     
        public int? NoUrutSales { get; set; }
     
     
        public string Keterangan { get; set; }
        public string Batal { get; set; }
     
        public int? MasterKategoriPenjualanId { get; set; }
        public string Mediator { get; set; }
     
     //   public int? KdMarco { get; set; }
        public int? UserInputId { get; set; }
        public string UserInput { get; set; }
      
       
        public PenjualanDetail PenjualanDetail { get; set; }




    }
}
