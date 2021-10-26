using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.DataSPK
{
    public class CreateDataSPKKendaraanRequest
    {
        public int DataSPKId { get; set; }
        public int MasterBarangId { get;  set; }
        public string NamaSTNK { get;  set; }
        public string NoKTPSTNK { get;  set; }
        public string TahunPerakitan { get;  set; }
        public string Warna { get;  set; }
    }
}
