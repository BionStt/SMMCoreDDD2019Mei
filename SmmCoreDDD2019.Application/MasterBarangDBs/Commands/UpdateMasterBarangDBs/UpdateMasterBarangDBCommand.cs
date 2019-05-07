using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Commands.UpdateMasterBarangDBs
{
  public  class UpdateMasterBarangDBCommand:IRequest
    {
        public int NoUrutTypeKendaraan { get; set; }
        [Display(Name = "Type Kendaraan")]
        public string TypeKendaraan { get; set; }
        [Display(Name = "Nama Barang")]
        public string NamaBarang { get; set; }
        [Display(Name = "Harga")]
        public decimal Harga { get; set; }
        [Display(Name = "BBN")]
        public decimal BBN { get; set; }
     
        [Display(Name = "Merek")]
        public string Merek { get; set; }
        [Display(Name = "Kapasitas Mesin")]
        public string Cc { get; set; }
        [Display(Name = "Kode Nomor Rangka")]
        public string NomorRangka { get; set; }
        [Display(Name = "Kode Nomor Mesin")]
        public string NomorMesin { get; set; }
        [Display(Name = "Tahun Perakitan")]
        public int Tahun { get; set; }
        [Display(Name = "Tipe")]
        public string Tipe { get; set; }
      
        [Display(Name = "Aktif")]
        public string Aktif { get; set; }
    }
}
