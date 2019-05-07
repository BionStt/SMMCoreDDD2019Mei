using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.STNKDBs.Command.CreateSTNKDB
{
    public class CreateSTNKDBCommandValidator:AbstractValidator<CreateSTNKDBCommand>
    {
        public CreateSTNKDBCommandValidator()
        {
            //RuleFor(x => x.NoRangka).NotEmpty();
            //RuleFor(x => x.NoMesin).NotEmpty();
            //RuleFor(x => x.Warna).NotEmpty();
            //RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();

        }
    }
}
