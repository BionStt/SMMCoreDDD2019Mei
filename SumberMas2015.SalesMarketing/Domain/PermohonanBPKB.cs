using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class PermohonanBPKB
    {
        protected PermohonanBPKB()
        {

        }
        public static PermohonanBPKB CreatePermohonanBPKB(Guid permohonanFakturId, string nomorBpkb, DateTime tanggalTerimaBPKB, string userName, Guid userNameId)
        {
            return new PermohonanBPKB(permohonanFakturId, nomorBpkb, tanggalTerimaBPKB,userName,userNameId);

        }
        private PermohonanBPKB(Guid permohonanFakturId, string nomorBpkb, DateTime tanggalTerimaBPKB, string userName, Guid userNameId)
        {
            PermohonanBPKBId = Guid.NewGuid();
            PermohonanFakturId = permohonanFakturId;
            NomorBpkb = nomorBpkb;
            TanggalTerimaBPKB = tanggalTerimaBPKB;
            UserName=userName;
            UserNameId=userNameId;
        }

        public Guid PermohonanBPKBId { get; set; }

        public int NoUrutId { get; set; }
        public Guid PermohonanFakturId { get; set; }
        public string NomorBpkb { get; set; }
        public DateTime TanggalTerimaBPKB { get; set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }

    }
}
