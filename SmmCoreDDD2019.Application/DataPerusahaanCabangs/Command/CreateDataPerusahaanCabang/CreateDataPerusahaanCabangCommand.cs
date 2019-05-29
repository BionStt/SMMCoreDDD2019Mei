using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.CreateDataPerusahaanCabang
{
   public class CreateDataPerusahaanCabangCommand:IRequest
    {
        [Display(Name = "Kantor Induk")]
        public int KodeP { get; set; }
        // public int KodePosisi { get; set; }
        [Display(Name = "Nama Cabang")]
        public string NamaPosisi { get; set; }
        public string Alamat { get; set; }
        [Display(Name = "Kelurahan")]
        public string Kel { get; set; }
        [Display(Name = "Kecamatan")]
        public string Kec { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePos { get; set; }
        [Display(Name = "Telepon")]
        public string Telp { get; set; }
        [Display(Name = "Penanggung Jawab")]
        public string Cp { get; set; }
       // public DataPerusahaan DataPerusahaan { get; set; }
    }
}
