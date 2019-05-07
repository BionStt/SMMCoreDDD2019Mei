using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.CreateMasterSupplierDB
{
  public  class CreateMasterSupplierDBCommandValidator:AbstractValidator<CreateMasterSupplierDBCommand>
    {
        public CreateMasterSupplierDBCommandValidator()
        {
            //RuleFor(x => x.Id).Length(5).NotEmpty();
            //RuleFor(x => x.Address).MaximumLength(60);
            //RuleFor(x => x.City).MaximumLength(15);
            //RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();

        }
    }
}
