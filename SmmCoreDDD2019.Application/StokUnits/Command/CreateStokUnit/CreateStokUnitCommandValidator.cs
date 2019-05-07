using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.StokUnits.Command.CreateStokUnit
{
    public class CreateStokUnitCommandValidator:AbstractValidator<CreateStokUnitCommand>
    {
        public CreateStokUnitCommandValidator()
        {
            RuleFor(x => x.NoRangka).NotEmpty();
            RuleFor(x => x.NoMesin).NotEmpty();
            RuleFor(x => x.Warna).NotEmpty();
            //RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();
        }

    }
}
