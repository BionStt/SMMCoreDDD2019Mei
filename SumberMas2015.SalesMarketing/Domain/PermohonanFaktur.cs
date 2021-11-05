using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class PermohonanFaktur
    {
        public Guid PermohonanFakturId { get; set; }


        public string NoRegistrasiFaktur { get; set; }
        public DateTime? TanggalMohonFaktur { get; set; }
        public Guid PenjualanDetailId { get; set; }
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



    }
}
