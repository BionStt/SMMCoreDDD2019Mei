using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.DeleteMasterLeasingDb
{
   public class DeleteMasterLeasingDbCommandValidator : AbstractValidator<DeleteMasterLeasingDbCommand>
    {
        public DeleteMasterLeasingDbCommandValidator()
         {
            RuleFor(v => v.ID).NotEmpty();

        }



    }
}
