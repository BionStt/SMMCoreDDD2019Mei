using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MediatR;
namespace SmmCoreDDD2019.Application.Pembelians.Command.CreatePembelian
{
    public class CreatePembelianCommand:IRequest
    {
        [Display(Name = "NoPoPembelian")]
        public int? NoPOPembelian { get; set; }

        [Display(Name = "Nama Supplier")]
        public int? Idsupplier { get; set; }
        [Display(Name = "Jenis Transaksi")]
        public string JenisTransPmb { get; set; }
        [Display(Name = "Kredit")]
        public string Kredit { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
        [Display(Name = "User ID")]
        public int? UserInputId { get; set; }
        [Display(Name = "User Input")]
        public string UserInput { get; set; }
      
    }
}
