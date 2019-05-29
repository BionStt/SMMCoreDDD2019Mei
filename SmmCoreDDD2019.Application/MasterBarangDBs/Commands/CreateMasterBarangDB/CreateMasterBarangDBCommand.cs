using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Commands.CreateMasterBarangDB
{
   public class CreateMasterBarangDBCommand:IRequest
    {
        //  public int NoUrutTypeKendaraan { get; set; }
        [Display(Name = "Type Kendaraan")]
        public string TypeKendaraan { get; set; }
        [Display(Name = "Nama Barang")]
        public string NamaBarang { get; set; }
        public string Tipe { get; set; }
        public string Merek { get; set; }
        [Display(Name = "Kode Nomor Rangka")]
        public string NomorRangka { get; set; }
        [Display(Name = "Kode Nomor Mesin")]
        public string NomorMesin { get; set; }
        [Display(Name = "Tahun Perakitan")]
        public int? Tahun { get; set; }
        [Display(Name = "Kapasitas Mesin (CC)")]
        public string Cc { get; set; }
        [Display(Name = "Harga Off The Road")]
        public decimal? Harga { get; set; }
        [Display(Name = "BBN")]
        public decimal? BBN { get; set; }
        public string Aktif { get; set; }







    }
}
