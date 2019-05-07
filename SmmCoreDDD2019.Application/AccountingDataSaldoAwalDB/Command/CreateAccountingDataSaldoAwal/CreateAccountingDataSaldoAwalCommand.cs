using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.AccountingDataSaldoAwalDB.Command.CreateAccountingDataSaldoAwal
{
    public class CreateAccountingDataSaldoAwalCommand:IRequest
    {
        public int NoUrutSaldoAwalID { get; set; }
        [Display(Name = "Tanggal Input")]

        public DateTime TanggalInput { get; set; }
        [Display(Name = "Periode Pembukuan")]
        public string NoUrutPeriodeID { get; set; }
        [Display(Name = "Nama Akun")]
        public string NoUrutAccountId { get; set; }
        [Display(Name = "Debet")]
        public Decimal Debet { get; set; }
        [Display(Name = "Kredit")]
        public Decimal Kredit { get; set; }
        [Display(Name = "Saldo")]
        public Decimal Saldo { get; set; }
        [Display(Name = "Mata Uang")]

        public string MataUangID { get; set; }
        [Display(Name = "Nilai Kurs")]
        public Decimal NilaiKurs { get; set; }
        [Display(Name = "User Input")]
        public string UserInput { get; set; }

    }
}
