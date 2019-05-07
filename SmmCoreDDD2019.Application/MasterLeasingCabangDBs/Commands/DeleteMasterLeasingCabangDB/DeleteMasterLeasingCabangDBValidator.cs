using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.DeleteMasterLeasingCabangDB
{
    public    class DeleteMasterLeasingCabangDBValidator:AbstractValidator<DeleteMasterLeasingCabangDBCommand>
    {
        public DeleteMasterLeasingCabangDBValidator()
        {

            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
