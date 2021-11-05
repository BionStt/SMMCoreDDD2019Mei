using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class PermohonanBPKB
    {
        public Guid PermohonanBPKBId { get; set; }


        public int PermohonanFakturId { get; set; }
        public string NomorBpkb { get; set; }
        public DateTime TanggalTerimaBPKB { get; set; }
    }
}
