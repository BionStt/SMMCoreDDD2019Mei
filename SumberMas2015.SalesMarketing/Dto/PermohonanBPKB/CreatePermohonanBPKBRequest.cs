using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.PermohonanBPKB
{
    public class CreatePermohonanBPKBRequest
    {
        public string NoBPKB { get; internal set; }
        public int? NoUrutFaktur { get; internal set; }
        public DateTime TanggalTerimaBPKB { get; internal set; }
    }
}
