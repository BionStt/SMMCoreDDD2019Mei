using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataKontrakSurvei : BaseEntity
    {
       // public int NoUrutDataSurvei { get; set; }
        public string NoRegistrasiDataSurvei { get; set; }
        public DateTime? TanggalSurvei { get; set; }
        public string NoRegistrasiKonsumen { get; set; }
        public string Karakter { get; set; }
        public string Kerjasama { get; set; }
        public decimal? Penghasilan { get; set; }
        public decimal? Penghasilanlain { get; set; }
        public decimal? PenghasilanPasangan { get; set; }
        public decimal? PengeluaranTetapBulanan { get; set; }
        public int? Tanggungan { get; set; }
        public string StatusTempatTinggal { get; set; }
        public int? TinggalSejak { get; set; }
        public string HasilSurvei { get; set; }
        public string KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public string KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
        public decimal? OmzetBulanan { get; set; }
        public string PernahKredit { get; set; }
        public string NoUrutMasterBarang { get; set; }
        public string FasilitasKreditBank { get; set; }
        public string JenisFasilitasbank { get; set; }
        public string NamaRekeningBank { get; set; }
        public string NoRekeningBank { get; set; }
        public string LuasRumah { get; set; }
        public string LuasTanah { get; set; }
        public string LuasUsaha { get; set; }
        public string DayaListrikRumah { get; set; }
        public decimal? TagihanPLN { get; set; }
        public decimal? TagihanTelp { get; set; }
        public decimal? TagihanPDAM { get; set; }
        public string KondisiFisikRumah { get; set; }
        public string SegmenRumah { get; set; }
        public string KondisiJalanRumah { get; set; }
        public string PagarRumah { get; set; }
        public string TamanRumah { get; set; }
        public string GarasiRumah { get; set; }
        public int? KapasitasGarasiRumah { get; set; }
        public string DindingRumah { get; set; }
        public string AtapRumah { get; set; }
        public string LantaiRumah { get; set; }
        public string ToiletRumah { get; set; }
        public string TelevisiRumah { get; set; }
        public string Kulkas { get; set; }
        public string LokasiSurvei { get; set; }
        public string LokasiTempatTinggal { get; set; }
        public string NamaMendesak { get; set; }
        public string AlamatMendesak { get; set; }
        public string KelurahanMendesak { get; set; }
        public string KecamatanMendesak { get; set; }
        public string KotaMendesak { get; set; }
        public string PropinsiMendesak { get; set; }
        public string KodePosMendesak { get; set; }
        public string TelpMendesak { get; set; }
        public string HandphoneMendesak { get; set; }
        public string HandphoneMendesak2 { get; set; }
        public string HubunganDenganMendesak { get; set; }
        public string SurveiId { get; set; }
        public string KeteranganLain { get; set; }
    }
}
