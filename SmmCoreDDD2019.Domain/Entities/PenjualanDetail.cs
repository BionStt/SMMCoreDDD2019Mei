using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class PenjualanDetail : BaseEntity
    {
      //  public int NoPenjualanDetail { get; set; }
      public int? PenjualanId { get; set; }
        public int? StokUnitId { get; set; }
        public decimal? OffTheRoad { get; set; }
        public decimal? BBN { get; set; }
        public decimal? HargaOTR { get; set; }
        public decimal? UangMuka { get; set; }
        public decimal? DiskonKredit { get; set; }
        public decimal? DiskonTunai { get; set; }
        public decimal? Subsidi { get; set; }
        public decimal? Promosi { get; set; }
        public decimal? Komisi { get; set; }
        public decimal? JoinPromo1 { get; set; }
        public decimal? JoinPromo2 { get; set; }
        public decimal? SPF { get; set; }
        public decimal? SellOut { get; set; }
        public decimal? DendaWilayah { get; set; }
        public string CheckDp { get; set; }
        public string CheckLapBulanan { get; set; }
        public DateTime? TanggalCheckLapBulanan { get; set; }
        public string UserCheckLapBulanan { get; set; }

        public PenjualanPiutang PenjualanPiutang { get; set; }
        public PermohonanFakturDB PermohonanFakturDB { get; set; }

    }
}
