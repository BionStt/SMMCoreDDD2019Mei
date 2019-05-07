using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class Pembelian
    {
        public int KodeBeli { get; set; }
    public string NoRegistrasiPembelian { get; set; }
        public DateTime? TglBeli { get; set; }
     
        public int? Idsupplier { get; set; }
     
        public string JenisTransPmb { get; set; }
        public string Kredit { get; set; }
     
        public string Keterangan { get; set; }
        public string Batal { get; set; }
        public int? UserInputId { get; set; }
        public string UserInput { get; set; }
       
        public int? NoPOPembelian { get; set; }

    }
}
