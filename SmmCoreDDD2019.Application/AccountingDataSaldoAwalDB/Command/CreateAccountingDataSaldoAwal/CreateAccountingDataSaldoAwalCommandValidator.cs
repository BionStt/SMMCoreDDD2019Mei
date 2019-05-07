using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.AccountingDataSaldoAwalDB.Command.CreateAccountingDataSaldoAwal
{
    public class CreateAccountingDataSaldoAwalCommandValidator:AbstractValidator<CreateAccountingDataSaldoAwalCommand>
    {
        public CreateAccountingDataSaldoAwalCommandValidator()
        {

        }
    }
}
