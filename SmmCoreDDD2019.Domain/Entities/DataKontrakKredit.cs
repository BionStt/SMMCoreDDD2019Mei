using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataKontrakKredit : BaseEntity
    {
       // public int NoUrutDataKontrakKredit { get; set; }
        public string NoRegisterKontrakKredit { get; set; }
        public int DataKontrakSurveiId { get; set; }
        public DateTime? TanggalKontrak { get; set; }
        public string PolaAngsuran { get; set; }
        public string CaraBayar { get; set; }
        public double? HargaBarang { get; set; }
        public double? UangMuka { get; set; }
        public double? Asuransi { get; set; }
        public double? Administrasi { get; set; }
        public decimal? BungaEff { get; set; }
        public decimal? BungaFlat { get; set; }
        public int? LamaKredit { get; set; }
        public string TanggalAngsuranBulanan { get; set; }
        public string AngsuranDimuka { get; set; }
        public double? NilaiBunga { get; set; }
        public double? NilaiKontrak { get; set; }
        public double? PinjamanPokok { get; set; }
        public double? AngsuranBulanan { get; set; }
        public double? BiayaAdministrasiAngsuran { get; set; }
        public string PenagihId { get; set; }

        public DataKontrakAngsuran DataKontrakAngsuran { get; set; }
    }
}
