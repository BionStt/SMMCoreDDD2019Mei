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
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.CreateDataPegawaiDataRiwayatPendidikan
{
   public class CreateDataPegawaiDataRiwayatPendidikanCommand:IRequest
    {
        //  public int NoUrut { get; set; }
        [Display(Name = "Nama Pegawai")]
        public int? IDPegawai { get; set; }
        [Display(Name = "Tingkat Pendidikan")]
        public string TingkatPend { get; set; }
        [Display(Name = "Nama Sekolah")]
        public string NamaSekolah { get; set; }
        public string Kota { get; set; }
        public string Jurusan { get; set; }
        [Display(Name = "Tahun Kelulusan")]
        public int? TahunLulus { get; set; }
        public string Keterangan { get; set; }
      //  public DataPegawai DataPegawai { get; set; }
    }
}
