﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataMataUang : BaseEntity
    {
        // public int MataUangID { get; set; }
        public string Kode { get; set; }
        public string Nama { get; set; }


        public AccountingDataAccount AccountingDataAccount { get; set; }

     //   public AccountingDataSaldoAwal AccountingDataSaldoAwal { get; set; }


    }
}
