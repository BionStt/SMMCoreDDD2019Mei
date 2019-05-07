using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.CreateDataPegawaiDataKeluarga
{
    public class CreateDataPegawaiDataKeluargaCommand:IRequest
    {
        //public int NoUrut { get; set; }
        [Display(Name = "Nama Pegawai")]
        public int? IDPegawai { get; set; }
        [Display(Name = "Nama Keluarga", Prompt = "Nama Keluarga")]
        public string NamaK { get; set; }
        [Display(Name = "Alamat Rumah Keluarga")]
        public string AlamatK { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanK { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanK { get; set; }
        [Display(Name = "Kota")]
        public string KotaK { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosK { get; set; }
        [Display(Name = "Telepon")]
        public string Telp { get; set; }
        [Display(Name = "Handphone")]
        public string Handphone { get; set; }
        [Display(Name = "Nomor KTP",Prompt ="Masukkan Nomor KTP")]
        public string NoKtp { get; set; }
        [Display(Name = "Hubungan dengan Keluarga")]
        public string HubunganK { get; set; }
        [Display(Name = "Jenis Kelamin")]
        public string JenisKelamin { get; set; }
        [Display(Name = "Tempat Lahir")]
        public string TempatLahir { get; set; }
        [Display(Name = "Tanggal Lahir"), DataType(DataType.Text)]
        public DateTime? Tgllahir { get; set; }
        [Display(Name = "Pendidikan Terakhir")]
        public string PendidikanTerakhir { get; set; }
        [Display(Name = "Agama")]
        public string Agama { get; set; }
        [Display(Name = "Pekerjaan")]
        public string Pekerjaan { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
        [Display(Name = "Dapat Dihubungin Ketika dalam keadaan darurat?")]
        public string EmergencyCall { get; set; }
      //  public DateTime? TglInput { get; set; }
      //  public DataPegawai DataPegawai { get; set; }
    }
}
