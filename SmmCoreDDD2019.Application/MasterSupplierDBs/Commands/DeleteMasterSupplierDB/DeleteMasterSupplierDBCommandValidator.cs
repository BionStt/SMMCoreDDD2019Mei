using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.DeleteMasterSupplierDB
{
   public class DeleteMasterSupplierDBCommandValidator:AbstractValidator<DeleteMasterSupplierDBCommand>
    {
        public DeleteMasterSupplierDBCommandValidator()
        {
         //   RuleFor(v => v.Id).NotEmpty().Length(5);
        }

    }
}
