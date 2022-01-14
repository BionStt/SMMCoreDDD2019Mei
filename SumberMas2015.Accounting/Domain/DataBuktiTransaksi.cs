using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Domain
{
    public class DataBuktiTransaksi
    {
        public Guid DataBuktiTransaksiId { get; private set; }
        public int NoUrutId { get; private set; }

        public int TipeJournalId { get; private set; }
        public string NoBukti { get; private set; }
        public DateTime TanggalInput { get; private set; }
        public string Keterangan { get; private set; }
        public string ValidateBy { get; private set; }
        public DateTime ValidatedDate { get; private set; }
        public Decimal Total { get; private set; }

    }
}
