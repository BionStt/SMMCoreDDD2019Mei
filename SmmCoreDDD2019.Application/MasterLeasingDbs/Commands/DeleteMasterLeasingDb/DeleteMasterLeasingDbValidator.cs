using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.DeleteMasterLeasingDb
{
   public class DeleteMasterLeasingDbValidator:AbstractValidator<DeleteMasterLeasingDbCommand>
    {
        public DeleteMasterLeasingDbValidator()
         {
            RuleFor(v => v.ID).NotEmpty();

        }



    }
}
