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

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.CreateDataPegawaiDataRiwayatPekerjaan
{
    public class CreateDataPegawaiDataRiwayatPekerjaanCommand:IRequest
    {
       // public int NoUrut { get; set; }
        [Display(Name = "Nama Pegawai")]
        public int? IDPegawai { get; set; }
        [Display(Name = "Nama Perusahaan")]
        public string NamaPerusahaan { get; set; }
        [Display(Name = "Alamat")]
        public string AlamatP { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanP { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanP { get; set; }
        [Display(Name = "Kota")]
        public string KotaP { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosP { get; set; }
        [Display(Name = "Telepon")]
        public string TelpP { get; set; }
        [Display(Name = "Jabatan Awal")]
        public string JabatanAwal { get; set; }
        [Display(Name = "Jabatan Akhir")]
        public string JabatanAkhir { get; set; }
        [Display(Name = "Mulai Bekerja"), DataType(DataType.Text)]
        public DateTime? MulaiBekerja { get; set; }
        [Display(Name = "Terakhir Bekerja"), DataType(DataType.Text)]
        public DateTime? AkhirBekerja { get; set; }
        [Display(Name = "Gaji Terakhir")]
        public decimal? GajiTerakhir { get; set; }
        [Display(Name = "Nama Atasan Pada perusahaan")]
        public string AtasanP { get; set; }
        // public DateTime? TglInput { get; set; }
      
        public string Keterangan { get; set; }
      //  public DataPegawai DataPegawai { get; set; }
    }
}
