using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.CreateMasterSupplierDB
{
   public class CreateMasterSupplierDBCommand :IRequest
    {
     //   public int IDSupplier { get; set; }
      
        [Display(Name = "Nama Supplier",Prompt ="Masukkan Nama Supplier")]
        public string NamaSupplier { get; set; }
        [Display(Name = "Alamat")]
        public string Alamat { get; set; }
        [Display(Name = "Kelurahan")]
        public string Kelurahan { get; set; }
        [Display(Name = "Kecamatan")]
        public string Kecamatan { get; set; }
        [Display(Name = "Kota")]
        public string Kota { get; set; }
        [Display(Name = "Propinsi")]
        public string Propinsi { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePos { get; set; }
        [Display(Name = "Telepon")]
        public string Telp { get; set; }
        [Display(Name = "Faks")]
        public string Faks { get; set; }
       
        public string Email { get; set; }
        public string Aktif { get; set; }
    }
}
