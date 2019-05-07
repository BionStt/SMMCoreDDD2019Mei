using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.CreateDataPerusahaanCabang
{
    public class CreateDataPerusahaanCabangCommandValidator : AbstractValidator<CreateDataPerusahaanCabangCommand>
    {
        public  CreateDataPerusahaanCabangCommandValidator()
            {
            //RuleFor(x => x.Id).Length(5).NotEmpty();
            //RuleFor(x => x.Address).MaximumLength(60);
            //RuleFor(x => x.City).MaximumLength(15);

        }

    }
}
