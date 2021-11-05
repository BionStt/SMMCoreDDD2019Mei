using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.PermohonanSTNK
{
    public class CreatePermohonanSTNKRequest
    {
        public DateTime? TanggalBayarSTNK { get; set; }

        public int? NoUrutFaktur { get; set; }

        public string NoStnk { get; set; }

        public decimal PajakStnk { get; set; }

        public decimal Birojasa { get; set; }

        public decimal BiayaTambahan { get; set; }

        public decimal FormA { get; set; }

        public string NomorPlat { get; set; }

        public decimal? Perwil { get; set; }

        public decimal? PajakProgresif { get; set; }

        public decimal? BbnPabrik { get; set; }

        public int ProgresifKe { get; set; }
    }
}
