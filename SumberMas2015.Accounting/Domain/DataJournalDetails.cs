using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Domain
{
    public class DataJournalDetails
    {
        protected DataJournalDetails()
        {

        }
        private DataJournalDetails(Guid dataJournalHeaderId, Guid dataAccountId, decimal? debit, decimal? kredit, string keterangan)
        {
            DataJournalHeaderId = dataJournalHeaderId;
            DataAccountId = dataAccountId;
            Debit = debit;
            Kredit = kredit;
            Keterangan = keterangan;
        }
        public static DataJournalDetails CreateDataJournalDetails(Guid dataJournalHeaderId, Guid dataAccountId, decimal? debit, decimal? kredit, string keterangan)
        {
            return new DataJournalDetails(dataJournalHeaderId, dataAccountId, debit, kredit, keterangan);
        }
        public Guid DataJournalDetailsId { get; private set; }
        public int NoUrutId { get; private set; }

        public Guid DataJournalHeaderId { get; private set; }
        public Guid DataAccountId { get; private set; }
        public Decimal? Debit { get; private set; }
        public Decimal? Kredit { get; private set; }
        public string Keterangan { get; private set; }
        public DateTime TanggalInput { get; set; }
        public string SaldoAwal { get; set; }

        public static DataJournalDetails CreateSaldoAwal(Guid dataAccountId, Decimal debit, Decimal kredit)
        {
            var xx = new DataJournalDetails();
            xx.TanggalInput = DateTime.Now.Date;
            xx.DataAccountId = dataAccountId;
            xx.Debit = debit;
            xx.Kredit = kredit;
            xx.SaldoAwal = "1";
            xx.Keterangan = "Inputal Saldo Awal";
            xx.DataJournalDetailsId = Guid.NewGuid();

            return xx;

        }


    }
}
