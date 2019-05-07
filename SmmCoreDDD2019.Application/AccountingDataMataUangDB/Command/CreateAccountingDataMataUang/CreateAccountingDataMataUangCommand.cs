using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.AccountingDataMataUangDB.Command.CreateAccountingDataMataUang
{
    public class CreateAccountingDataMataUangCommand : IRequest
    {
        public int MataUangID { get; set; }
        [Display(Name = "Kode Mata Uang")]
        public string Kode { get; set; }
        [Display(Name = "Nama Mata Uang")]
        public string Nama { get; set; }
    }
}
