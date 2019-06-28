using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class PenjualanPiutang : BaseEntity
    {
       // public int NoUrutPjPiutang { get; set;}
        public DateTime TanggalLunas { get; set; }
        public string KodePenjualanDetail { get; set; }
        public string Keterangan { get; set; }
    }
}
