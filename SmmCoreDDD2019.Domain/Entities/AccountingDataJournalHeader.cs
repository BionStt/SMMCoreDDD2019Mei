﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataJournalHeader : BaseEntity
    {
      //  public int NoUrutJournalH { get; set; }
        public int AccountingDataPeriodeId { get; set; }
        public DateTime TanggalInput { get; set; }
        public string NoBuktiJournal { get; set; }
        public string Keterangan { get; set; }
        public int AccountingTipeJournalId { get; set; }
        public string UserInput { get; set; }
        public DateTime Validasi { get; set; }
        public string ValidasiOleh { get; set; }
        public string Aktif { get; set; }

        public AccountingDataJournal AccountingDataJournal { get; set; }
    }
}
