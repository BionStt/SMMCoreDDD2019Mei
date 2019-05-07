using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.AccountingDataMataUangDB.Command.CreateAccountingDataMataUang
{
    public class CreateAccountingDataMataUangCommandValidator:AbstractValidator<CreateAccountingDataMataUangCommand>
    {
        public CreateAccountingDataMataUangCommandValidator()
        {

        }
    }
}
