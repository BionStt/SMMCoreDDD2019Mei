using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.DeleteMasterLeasingCabangDB
{
    public    class DeleteMasterLeasingCabangDBCommandValidator : AbstractValidator<DeleteMasterLeasingCabangDBCommand>
    {
        public DeleteMasterLeasingCabangDBCommandValidator()
        {

            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
