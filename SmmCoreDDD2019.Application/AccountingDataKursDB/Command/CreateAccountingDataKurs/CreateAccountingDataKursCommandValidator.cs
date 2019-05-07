using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.AccountingDataKursDB.Command.CreateAccountingDataKurs
{
    public class CreateAccountingDataKursCommandValidator:AbstractValidator<CreateAccountingDataKursCommand>
    {
        public CreateAccountingDataKursCommandValidator()
        {

        }
    }
}
