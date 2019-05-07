using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.CreateDataPerusahaan
{
   public class CreateDataPerusahaanCommand:IRequest
    {

        //public int KodeP { get; set; }
        [Display(Name = "Nama Perusahaan")]
        public string NamaP { get; set; }
        [Display(Name = "Alamat Perusahaan")]
        public string AlamatP { get; set; }
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
        public string Cs { get; set; }
       // public ICollection<DataPerusahaanCabang> DataPerusahaanCabang { get; private set; }
    }
}
