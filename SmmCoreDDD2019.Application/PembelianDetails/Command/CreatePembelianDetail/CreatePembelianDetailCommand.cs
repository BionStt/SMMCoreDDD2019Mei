using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace SmmCoreDDD2019.Application.PembelianDetails.Command.CreatePembelianDetail
{
    public class CreatePembelianDetailCommand:IRequest
    {
        [Display(Name = "Kode Pembelian")]
        public int KodeBeli { get; set; }
        [Display(Name = "Nama Barang")]
        public int? KodeBrg { get; set; }
        [Display(Name = "Harga Off The Road")]
        public decimal? HargaOffTheRoad { get; set; }
        [Display(Name = "BBN")]
        public decimal? BBN { get; set; }
        [Display(Name = "Qty")]
        public int Qty { get; set; }
        [Display(Name = "Diskon")]
        public decimal? Diskon { get; set; }
        [Display(Name = "Sell In")]
        public decimal? SellIn { get; set; }
        //[Display(Name = "Harga 1")]
        //public decimal? Harga1 { get; set; }
        //[Display(Name = "Diskon 2")]
        //public decimal? Diskon2 { get; set; }
        //[Display(Name = "Sell IN 2")]
        //public decimal? SellIn2 { get; set; }
        //[Display(Name = "Harga PPN")]
        //public decimal? HargaPPN { get; set; }
        //[Display(Name = "Diskon PPN")]
        //public decimal? DiskonPPN { get; set; }
        //[Display(Name = "Sell IN PPN")]
        //public decimal? SellInPPN { get; set; }
    }
}
