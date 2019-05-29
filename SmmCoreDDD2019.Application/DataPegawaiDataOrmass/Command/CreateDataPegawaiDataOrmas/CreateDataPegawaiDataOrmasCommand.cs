using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.CreateDataPegawaiDataOrmas
{
    public class CreateDataPegawaiDataOrmasCommand:IRequest
    {
        // public int NoUrut { get; set; }
        [Display(Name = "Nama Pegawai")]
        public int? IDPegawai { get; set; }
        [Display(Name = "Nama Lembaga Organisasi Kemasyarakatan")]
        public string NamaOrmas { get; set; }
        [Display(Name = "Alamat")]
        public string AlamatOrmas { get; set; }
        [Display(Name = "Kota")]
        public string KotaOrmas { get; set; }
        [Display(Name = "Telepon")]
        public string TelpOrmas { get; set; }
        [Display(Name = "Status Jabatan Pada Lembaga Organisasi Kemasyarakatan")]
        public string Jabatan { get; set; }
        [Display(Name = "Jenis Kegiatan")]
        public string JenisKegiatan { get; set; }
        //public DateTime? TglInput { get; set; }
     //   public DataPegawai DataPegawai { get; set; }
    }
}
