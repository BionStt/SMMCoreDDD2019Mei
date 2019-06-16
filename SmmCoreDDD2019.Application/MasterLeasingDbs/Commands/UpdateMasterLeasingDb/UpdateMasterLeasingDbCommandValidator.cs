using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using FluentValidation.Validators;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.UpdateMasterLeasingDb
{
   public class UpdateMasterLeasingDbCommandValidator : AbstractValidator<UpdateMasterLeasingDbCommand>
    {
        public UpdateMasterLeasingDbCommandValidator()
        {
            RuleFor(x => x.IDlease).NotEmpty();
            RuleFor(x => x.NamaLease).NotEmpty();
        }
    }
}
