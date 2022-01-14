using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Domain
{
    public class TipeJournal
    {
        protected TipeJournal()
        {

        }
        private TipeJournal(string kodeJournal, string namaJournal)
        {
            TipeJournalId = Guid.NewGuid();
            KodeJournal = kodeJournal;
            NamaJournal = namaJournal;
        }
        public static TipeJournal CreateTipeJournal(string kodeJournal, string namaJournal)
        {
            return new TipeJournal(kodeJournal, namaJournal);
        }

        public Guid TipeJournalId { get; private set; }
        public int NoUrutId { get; private set; }
        public string KodeJournal { get; private set; }
        public string NamaJournal { get; private set; }




    }
}
