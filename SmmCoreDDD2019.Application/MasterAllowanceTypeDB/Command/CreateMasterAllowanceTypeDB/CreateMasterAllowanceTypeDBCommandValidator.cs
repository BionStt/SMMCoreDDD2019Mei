using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.MasterAllowanceTypeDB.Command.CreateMasterAllowanceTypeDB
{
    public class CreateMasterAllowanceTypeDBCommandValidator : AbstractValidator<CreateMasterAllowanceTypeDBCommand>
    {
        public CreateMasterAllowanceTypeDBCommandValidator()
        {
            //RuleFor(x => x.NamaBarang).NotEmpty();
            //RuleFor(x => x.Merek).NotEmpty();
            //RuleFor(x => x.NomorRangka).NotEmpty();
            //RuleFor(x => x.NomorMesin).NotEmpty();

        }
    }
}
