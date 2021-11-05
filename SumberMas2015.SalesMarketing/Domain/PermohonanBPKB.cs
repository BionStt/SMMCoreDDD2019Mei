using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class PermohonanBPKB
    {
        public static PermohonanBPKB CreatePermohonanBPKB(Guid permohonanFakturId, string nomorBpkb, DateTime tanggalTerimaBPKB)
        {
            return new PermohonanBPKB(permohonanFakturId, nomorBpkb, tanggalTerimaBPKB);

        }
        private PermohonanBPKB( Guid permohonanFakturId, string nomorBpkb, DateTime tanggalTerimaBPKB)
        {
            PermohonanBPKBId = Guid.NewGuid();
            PermohonanFakturId = permohonanFakturId;
            NomorBpkb = nomorBpkb;
            TanggalTerimaBPKB = tanggalTerimaBPKB;
        }

        public Guid PermohonanBPKBId { get; set; }

        public int NoUrutId { get; set; }
        public Guid PermohonanFakturId { get; set; }
        public string NomorBpkb { get; set; }
        public DateTime TanggalTerimaBPKB { get; set; }
    }
}
