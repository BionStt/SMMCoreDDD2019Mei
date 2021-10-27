using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Dto.DataPerusahaan
{
    public class CreateDataPerusahaanRequest
    {
        public string NamaPerusahaan { get;  set; }
        public string PenanggungJawab { get;  set; }
        public string Jalan { get;  set; }
        public string Kelurahan { get;  set; }
        public string Kecamatan { get;  set; }
        public string Kota { get;  set; }
        public string Propinsi { get;  set; }
        public string KodePos { get;  set; }
        public string NomorTelepon { get;  set; }
        public string NomorFaks { get;  set; }
        public string NomorHandphone { get;  set; }
    }
}
