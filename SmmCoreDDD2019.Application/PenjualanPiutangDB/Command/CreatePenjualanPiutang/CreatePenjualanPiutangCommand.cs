using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.PenjualanPiutangDB.Command.CreatePenjualanPiutang
{
    public class CreatePenjualanPiutangCommand : IRequest
    {
        [Display(Name = "Tanggal Pembayaran")]
        public DateTime TanggalLunas { get; set; }
        [Display(Name = "Data Penjualan")]
        public string KodePenjualanDetail { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
    }
}
