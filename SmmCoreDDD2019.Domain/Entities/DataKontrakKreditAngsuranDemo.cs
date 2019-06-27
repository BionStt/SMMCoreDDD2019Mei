using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataKontrakKreditAngsuranDemo : BaseEntity
    {
      //  public int NoUrutDataKontrakKredit { get; set; }
        public int? AngsKe { get; set; }
        public string NoKwitansi { get; set; }
        public DateTime? TglAngsuran { get; set; }
        public Double? Angsuran { get; set; }
       
        public Double? Pokok { get; set; }
        public Double? Bunga { get; set; }
        public Double? SisaPokok { get; set; }
        public Double? SisaBunga { get; set; }
        public Double? Denda { get; set; }
        public Double? DiskonDenda { get; set; }
        public Double? TitipanAngsuran { get; set; }
        public DateTime? TglByrAngsuran { get; set; }
        public int? CaraBayar { get; set; }
        public Double? BiayaAdm { get; set; }
        public string PenagihId { get; set; }
    }
}
