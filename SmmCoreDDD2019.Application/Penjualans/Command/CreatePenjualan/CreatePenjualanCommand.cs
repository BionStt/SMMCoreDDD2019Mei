using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;


namespace SmmCoreDDD2019.Application.Penjualans.Command.CreatePenjualan
{
    public class CreatePenjualanCommand:IRequest
    {
        [Display(Name = "Data SPK")]
        public int? NoUrutSPK { get; set; }
        [Display(Name = "Tanggal Penjualan"),DataType(DataType.Text)]
        public DateTime? TanggalPenjualan { get; set; }
        [Display(Name = "Nama Pemesan")]
        public int? KodeKonsumen { get; set; }
        [Display(Name = "Leasing Cabang")]
        public int? KodeLease { get; set; }
        [Display(Name = "No Buku",Prompt ="Input Nomor Buku")]
        public string NoBuku { get; set; }
        [Display(Name = "Sales Force")]
        public int? NoUrutSales { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
       
        public string Batal { get; set; }
        [Display(Name = "Kategori Penjualan")]
        public int? KategoriPenjualan { get; set; }
        [Display(Name = "Mediator / Makelar")]
        public string Mediator { get; set; }

        public int? UserInputId { get; set; }
        public string UserInput { get; set; }


    }
}
