using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.StokUnits.Command.CreateStokUnit
{
    public class CreateStokUnitCommand:IRequest
    {
        [Display(Name = "Kode Pembelian Detail")]
        public int? KodeBeliDetail { get; set; }
        [Display(Name = "Nama Barang")]
        public int? KodeBrg { get; set; }
        [Display(Name = "Harga")]
        public decimal? Harga { get; set; }
        [Display(Name = "Diskon")]
        public decimal? Diskon { get; set; }
        [Display(Name = "Sell In")]
        public decimal? SellIn { get; set; }
        [Display(Name = "Nomor Rangka")]
        public string NoRangka { get; set; }
        [Display(Name = "Nomor Mesin")]
        public string NoMesin { get; set; }
        [Display(Name = "Warna")]
        public string Warna { get; set; }
      
        //public decimal? Harga1 { get; set; }
        //public decimal? Diskon2 { get; set; }
        //public decimal? SellIn2 { get; set; }
        //public decimal? HargaPPN { get; set; }
        //public decimal? DiskonPPN { get; set; }
        //public decimal? SellInPPN { get; set; }
        //public string Jual { get; set; }
        //public string Kembali { get; set; }
        //public string Faktur { get; set; }
    }
}
