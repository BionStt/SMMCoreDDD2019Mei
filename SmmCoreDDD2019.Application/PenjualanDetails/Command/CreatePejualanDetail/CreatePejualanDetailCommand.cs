using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;


namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.CreatePejualanDetail
{
    public class CreatePejualanDetailCommand:IRequest
    {
        [Display(Name = "Nama Pemesan")]
        public int? KodePenjualan { get; set; }
        [Display(Name = "Pilihan Unit")]
        public int? NoUrutSO { get; set; }
        [Display(Name = "Off The Road")]
        public decimal? OffTheRoad { get; set; }
        [Display(Name = "BBN")]
        public decimal? BBN { get; set; }
        [Display(Name = "Harga OTR")]
        public decimal? HargaOTR { get; set; }
        [Display(Name = "Uang Muka")]
        public decimal? UangMuka { get; set; }
        [Display(Name = "Diskon Kredit")]
        public decimal? DiskonKredit { get; set; }
        [Display(Name = "Diskon Tunai")]
        public decimal? DiskonTunai { get; set; }
        [Display(Name = "Subsidi")]
        public decimal? Subsidi { get; set; }
        [Display(Name = "Promosi")]
        public decimal? Promosi { get; set; }
        [Display(Name = "Komisi")]
        public decimal? Komisi { get; set; }
        [Display(Name = "Join Promo I")]
        public decimal? JoinPromo1 { get; set; }
        [Display(Name = "Join Promo II")]
        public decimal? JoinPromo2 { get; set; }
        [Display(Name = "SPF")]
        public decimal? SPF { get; set; }
        [Display(Name = "Sell Out")]
        public decimal? SellOut { get; set; }
        [Display(Name = "Denda Wilayah")]
        public decimal? DendaWilayah { get; set; }
      
    }
}
