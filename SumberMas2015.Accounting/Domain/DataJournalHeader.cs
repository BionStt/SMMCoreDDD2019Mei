using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Domain
{
    public class DataJournalHeader
    {
        protected DataJournalHeader()
        {

        }
        private DataJournalHeader(DateTime tanggalInput, string keterangan, int tipeJournalId, string userInput, string NoBuktiJournal1, decimal totalRupiah)
        {
            // NoBuktiJournal = noBuktiJournal;
            //NoBuktiJournal = GenerateNBJ(DateTime.Now);
            NoBuktiJournal = NoBuktiJournal1;
            Keterangan = keterangan;
            TipeJournalId = tipeJournalId;
            UserInput = userInput;
            TanggalInput = tanggalInput;
            TotalRupiah = totalRupiah;
        }
        public static DataJournalHeader CreateDataJournalHeader(DateTime tanggalInput, string keterangan, int tipeJournalId, string userInput, string NoBuktiJournal1, decimal totalRupiah)
        {
            return new DataJournalHeader(tanggalInput, keterangan, tipeJournalId, userInput, NoBuktiJournal1, totalRupiah);

        }
        public Guid DataJournalHeaderId { get; private set; }
        public int NoUrutId { get; private set; }
        public DateTime TanggalInput { get; private set; }
        public DateTime? Validasi { get; private set; }
        public string ValidasiOleh { get; private set; }

        // public int? DataPeriodeId { get; private set; }

        public string NoBuktiJournal { get; private set; }
        public string Keterangan { get; private set; }
        public decimal TotalRupiah { get; private set; }
        public int TipeJournalId { get; private set; }
        public string UserInput { get; private set; }


        public string Aktif { get; private set; }


        private string GenerateNBJ(DateTime TanggalInput)
        {
            var bln = TanggalInput.Month;
            var thn = TanggalInput.Year;
            var NoBuktiJurnal = string.Empty;

            switch (bln)
            {
                case 1:
                    NoBuktiJurnal = "NBJ/" + "/I/" + thn;
                    break;
                case 2:
                    NoBuktiJurnal = "NBJ/" + "/II/" + thn;
                    break;
                case 3:
                    NoBuktiJurnal = "NBJ/" + "/III/" + thn;
                    break;
                case 4:
                    NoBuktiJurnal = "NBJ/" + "/IV/" + thn;
                    break;
                case 5:
                    NoBuktiJurnal = "NBJ/" + "/V/" + thn;
                    break;
                case 6:
                    NoBuktiJurnal = "NBJ/" + "/VI/" + thn;
                    break;
                case 7:
                    NoBuktiJurnal = "NBJ/" + "/VII/" + thn;
                    break;
                case 8:
                    NoBuktiJurnal = "NBJ/" + "/VIII/" + thn;
                    break;
                case 9:
                    NoBuktiJurnal = "NBJ/" + "/IX/" + thn;
                    break;
                case 10:
                    NoBuktiJurnal = "NBJ/" + "/X/" + thn;
                    break;
                case 11:
                    NoBuktiJurnal = "NBJ/" + "/XI/" + thn;
                    break;
                case 12:
                    NoBuktiJurnal = "NBJ/" + "/XII/" + thn;
                    break;
            }
            return NoBuktiJurnal;
        }

    }
}
