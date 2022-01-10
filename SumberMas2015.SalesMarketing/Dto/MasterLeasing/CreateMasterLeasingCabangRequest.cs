using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.MasterLeasing
{
    public class CreateMasterLeasingCabangRequest
    {
        public string NamaCabangLeasing { get; set; }
        public string EmailCabangLeasing { get; set; }
        public string Jalan { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }
        public string NoTelepon { get; set; }
        public string NoFax { get; set; }
        public string NoHandphone { get; set; }
        public int MasterLeasingId { get;  set; }
    }
}
