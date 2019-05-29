using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.CreateDataPegawaiDataRiwayatPelatihan
{
   public class CreateDataPegawaiDataRiwayatPelatihanCommand:IRequest
    {
        // public int NoUrut { get; set; }
        [Display(Name = "Nama Pegawai")]
        public int? IDPegawai { get; set; }
        [Display(Name = "Nama Lembaga Pelatihan")]
        public string NamaLembaga { get; set; }
        [Display(Name = "Alamat Lengkap")]
        public string AlamatLembaga { get; set; }
        [Display(Name = "Telepon")]
        public string TelpLembaga { get; set; }
        [Display(Name = "Lama Kursus/pendidikan")]
        public string LamaKursus { get; set; }
        [Display(Name = "Dibiayai Oleh:")]
        public string DibiayaiOleh { get; set; }
        [Display(Name = "Bidang Pelatihan")]
        public string BidangPelatihan { get; set; }
       // public DataPegawai DataPegawai { get; set; }

    }
}
