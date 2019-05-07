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
namespace SmmCoreDDD2019.Application.AccountingDataKursDB.Command.CreateAccountingDataKurs
{
    public class CreateAccountingDataKursCommand : IRequest
    {
        public int NoUrutKursID { get; set; }
        [Display(Name = "Mata Uang Pilihan")]
        public string MataUangID { get; set; }
        [Display(Name = "Tanggal")]
        public DateTime TanggalInput { get; set; }
        [Display(Name = "Nilai Mata Uang")]
        public decimal Nilai { get; set; }
    }
}
