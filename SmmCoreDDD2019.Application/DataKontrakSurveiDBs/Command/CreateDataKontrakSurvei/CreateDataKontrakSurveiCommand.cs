using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.CreateDataKontrakSurvei
{
    public class CreateDataKontrakSurveiCommand:IRequest
    {
        public int NoUrutDataSurvei { get; set; }
        //[Display(Name ="No Registrasi Data Survei")]
        //public string NoRegistrasiDataSurvei { get; set; }
        //[Display(Name = "Tanggal Survei"),DataType(DataType.Text)]
        //public DateTime? TanggalSurvei { get; set; }
        [Display(Name = "No Regisrasi Konsumen")]
        public int NoRegistrasiKonsumen { get; set; }
        [Display(Name = "Karakter")]
        public string Karakter { get; set; }
        [Display(Name = "Kerjasama")]
        public string Kerjasama { get; set; }
        [Display(Name = "Penghasilan")]
        public decimal? Penghasilan { get; set; }
        [Display(Name = "Penghasilan Lain?")]
        public decimal? Penghasilanlain { get; set; }
        [Display(Name = "Penghasilan Pasangan")]
        public decimal? PenghasilanPasangan { get; set; }
        [Display(Name = "Pengeluaran Tetap Bulanan")]
        public decimal? PengeluaranTetapBulanan { get; set; }
        [Display(Name = "Tanggungan")]
        public int? Tanggungan { get; set; }
        [Display(Name = "Status Tempat Tinggal")]
        public string StatusTempatTinggal { get; set; }
        [Display(Name = "Tinggal Sejak")]
        public int? TinggalSejak { get; set; }
        [Display(Name = "Hasil Survei")]
        public string HasilSurvei { get; set; }
        [Display(Name = "Bidang Pekerjaan")]
        public string KodeBidangPekerjaan { get; set; }
        [Display(Name = "Nama Pekerjaan")]
        public string NamaBidangPekerjaan { get; set; }
        [Display(Name = "Bidang Usaha")]
        public string KodeBidangUsaha { get; set; }
        [Display(Name = "Jenis Usaha")]
        public string NamaBidangUsaha { get; set; }
        [Display(Name = "Omzet Bulanan")]
        public decimal? OmzetBulanan { get; set; }
        [Display(Name = "Pernah Kredit ?")]
        public string PernahKredit { get; set; }
        [Display(Name = "Nama Barang")]
        public int NoUrutMasterBarang { get; set; }
        [Display(Name = "Fasilitas Kredit Bank?")]
        public string FasilitasKreditBank { get; set; }
        [Display(Name = "Jenis Fasilitas Kredit Bank")]
        public string JenisFasilitasbank { get; set; }
        [Display(Name = "Nama Rekening Bank")]
        public string NamaRekeningBank { get; set; }
        [Display(Name = "Nomor Rekening Bank")]
        public string NoRekeningBank { get; set; }
        [Display(Name = "Luas Rumah")]
        public string LuasRumah { get; set; }
        [Display(Name = "Luas Tanah")]
        public string LuasTanah { get; set; }
        [Display(Name = "Luas Usaha")]
        public string LuasUsaha { get; set; }
        [Display(Name = "Daya Listrik Rumah")]
        public string DayaListrikRumah { get; set; }
        [Display(Name = "Tagihan PLN")]
        public decimal? TagihanPLN { get; set; }
        [Display(Name = "Tagihan Telp")]
        public decimal? TagihanTelp { get; set; }
        [Display(Name = "Tagihan PDAM")]
        public decimal? TagihanPDAM { get; set; }
        [Display(Name = "Kondisi Fisik Rumah")]
        public string KondisiFisikRumah { get; set; }
        [Display(Name = "Segmen Rumah")]
        public string SegmenRumah { get; set; }
        [Display(Name = "Kondisi Jalan Menuju Rumah ")]
        public string KondisiJalanRumah { get; set; }
        [Display(Name = "Apakah Hunian Memiliki Pagar?")]
        public string PagarRumah { get; set; }
        [Display(Name = "Apakah Hunian Memiliki Taman ?")]
        public string TamanRumah { get; set; }
        [Display(Name = "Apakah Hunian memiliki Garasi ?")]
        public string GarasiRumah { get; set; }
        [Display(Name = "Kapasitas Garasi Rumah ?")]
        public int? KapasitasGarasiRumah { get; set; }
        [Display(Name = "Kondisi Dinding Rumah ?")]
        public string DindingRumah { get; set; }
        [Display(Name = "Kondisi Atap Rumah?")]
        public string AtapRumah { get; set; }
        [Display(Name = "Kondisi Lantai Rumah?")]
        public string LantaiRumah { get; set; }
        [Display(Name = "Apakah Ada Toilet ?")]
        public string ToiletRumah { get; set; }
        [Display(Name = "Apakah ada Televisi ?")]
        public string TelevisiRumah { get; set; }
        [Display(Name = "Apakah memiliki perabotan Kulkas ?")]
        public string Kulkas { get; set; }
        [Display(Name = "Kondisi Lingkungan Lokasi Survei ?")]
        public string LokasiSurvei { get; set; }
        [Display(Name = "Lokasi Tempat Tinggal?")]
        public string LokasiTempatTinggal { get; set; }
        [Display(Name = "Nama Keluarga yang dapat dihubungin dalam keadaan Mendesak?")]
        public string NamaMendesak { get; set; }
        [Display(Name = "alamat Rumah")]
        public string AlamatMendesak { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanMendesak { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanMendesak { get; set; }
        [Display(Name = "Kota")]
        public string KotaMendesak { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiMendesak { get; set; }
        [Display(Name = "Kode pos")]
        public string KodePosMendesak { get; set; }
        [Display(Name = "Telepon")]
        public string TelpMendesak { get; set; }
        [Display(Name = "No Handphone I")]
        public string HandphoneMendesak { get; set; }
        [Display(Name = "No Handphone II")]
        public string HandphoneMendesak2 { get; set; }
        [Display(Name = "Hubungan pemohon dengan keluarga?")]
        public string HubunganDenganMendesak { get; set; }
        [Display(Name = "Petugas Survei?")]
        public string SurveiId { get; set; }
        [Display(Name = "Keterangan Lain")]
        public string KeteranganLain { get; set; }
    }
}
