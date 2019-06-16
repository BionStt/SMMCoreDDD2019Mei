using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using FluentValidation.Validators;

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.UpdateMasterLeasingCabangDB
{
    public class UpdateMasterLeasingCabangDBCommandValidator : AbstractValidator<UpdateMasterLeasingCabangDBCommand>
    {
        public UpdateMasterLeasingCabangDBCommandValidator()
        {
            //RuleFor(x => x.Id).MaximumLength(5).NotEmpty();
            //RuleFor(x => x.Address).MaximumLength(60);
            //RuleFor(x => x.City).MaximumLength(15);
            //RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();
            //RuleFor(x => x.ContactName).MaximumLength(30);
            //RuleFor(x => x.ContactTitle).MaximumLength(30);
            //RuleFor(x => x.Country).MaximumLength(15);
        }
    }
}
