using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.CreateDataSPKLeasingDB
{
    public class CreateDataSPKLeasingDBCommand:IRequest
    {
        //  public int NoUrut { get; set; }
        [Display(Name = "Tanggal Survei"), DataType(DataType.Text)]
        public DateTime? TglSurvei { get; set; }
        [Display(Name = "Nama Pemesan")]
        public int? NoUrutSPKBaru { get; set; }
        [Display(Name = "Nama Leasing")]
        public int? NoUrutLeasingCabang { get; set; }

        [Display(Name = "Angsuran")]
        public decimal? Angsuran { get; set; }
        [Display(Name = "Tenor")]
        public int? Tenor { get; set; }
        [Display(Name = "Nama CMO")]
        public string NamaCmo { get; set; }

        [Display(Name = "Mediator")]
        public string Mediator { get; set; }
        [Display(Name = "Kategori Penjualan")]
        public int? NoUrutKategoriPenjualan { get; set; }

        [Display(Name = "Kategori Pembayaran")]
        public int? NoUrutKategoriBayaran { get; set; }
       
        //  public int? NoUrutMarco { get; set; }
        [Display(Name = "Nama Sales Force")]
        public int? NoUrutSales { get; set; }
      
      
       
      
      //  public DataSPKBaruDB DataSPKBaruDB { get; set; }
      //  public MasterKategoriBayaran MasterKategoriBayaran { get; set; }
     //   public MasterKategoriPenjualan MasterKategoriPenjualan { get; set; }
     //   public MasterLeasingCabangDB MasterLeasingCabangDB { get; set; }
        // public MasterLeasingDb MasterLeasingDb { get; set; }
    }
}
