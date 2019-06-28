using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class PermohonanFakturDB : BaseEntity
    {
        //  public int NoUrutFaktur { get; set; }
        public string NoRegistrasiFaktur { get; set; }
        public DateTime? TanggalMohonFaktur { get; set; }
        public int? PenjualanDetailId { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public string NomorKTP { get; set; }
        public string NamaFaktur { get; set; }
        public string Alamat { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }
        public string Telepon { get; set; }
        public string HandphoneF { get; set; }

        public BPKBDB BPKBDB { get; set; }
        public STNKDB STNKDB {get;set;}


    }
}
