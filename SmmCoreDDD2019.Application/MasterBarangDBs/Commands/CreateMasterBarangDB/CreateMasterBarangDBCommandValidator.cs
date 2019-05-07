using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Commands.CreateMasterBarangDB
{
   public class CreateMasterBarangDBCommandValidator: AbstractValidator<CreateMasterBarangDBCommand>
    {
        public CreateMasterBarangDBCommandValidator()
        {
            RuleFor(x => x.NamaBarang).NotEmpty();
            RuleFor(x => x.Merek).NotEmpty();
            RuleFor(x => x.NomorRangka).NotEmpty();
            RuleFor(x => x.NomorMesin).NotEmpty();


        }


    }
}
