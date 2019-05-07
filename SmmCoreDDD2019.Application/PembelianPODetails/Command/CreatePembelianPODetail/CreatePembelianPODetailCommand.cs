using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.PembelianPODetails.Command.CreatePembelianPODetail
{
    public class CreatePembelianPODetailCommand : IRequest
    {
        [Display(Name = "Data PO")]
        public int? NoUrutPo { get; set; }
        [Display(Name = "Nama Barang")]
        public int? NoUrutMasterBarang { get; set; }
        [Display(Name = "Harga Off The Road")]
        public decimal? OffTheRoad { get; set; }
        [Display(Name = "BBN")]
        public decimal? Bbn { get; set; }
        [Display(Name = "Diskon")]
        public decimal? Diskon { get; set; }
        [Display(Name = "Warna")]
        public string Warna { get; set; }
        [Display(Name = "Qty")]
        public int? Qty { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
    }
}
