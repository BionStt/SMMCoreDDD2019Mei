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

        public int? NoUrutSPK { get; set; }
        public DateTime? TanggalPenjualan { get; set; }
     
        public int? KodeKonsumen { get; set; }
      
        public int? KodeLease { get; set; }
     
        public string NoBuku { get; set; }
     
        public int? NoUrutSales { get; set; }
     
     
        public string Keterangan { get; set; }
        public string Batal { get; set; }
     
        public int? KategoriPenjualan { get; set; }
        public string Mediator { get; set; }
     
     //   public int? KdMarco { get; set; }
        public int? UserInputId { get; set; }
        public string UserInput { get; set; }
      
       
    }
}
