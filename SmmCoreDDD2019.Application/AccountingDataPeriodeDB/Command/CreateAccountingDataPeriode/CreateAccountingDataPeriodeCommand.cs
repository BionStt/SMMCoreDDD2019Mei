using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;

using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.AccountingDataPeriodeDB.Command.CreateAccountingDataPeriode
{
    public class CreateAccountingDataPeriodeCommand : IRequest
    {
      
        public int NoUrutPeriodeID { get; set; }
        [Display(Name = "Periode Awal")]
        public DateTime Mulai { get; set; }
        [Display(Name = "Periode Akhir")]
        public DateTime Berakhir { get; set; }
 
        public string IsAktif { get; set; }

        public string UserInput { get; set; }
    }
}
