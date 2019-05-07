using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.AccountingDataPeriodeDB.Command.CreateAccountingDataPeriode
{
    public class CreateAccountingDataPeriodeCommandValidator : AbstractValidator<CreateAccountingDataPeriodeCommand>
    {
        public CreateAccountingDataPeriodeCommandValidator()
        {

        }
    }
}
