using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.DeleteDataPegawaiFoto
{
   public class DeleteDataPegawaiFotoCommandValidator:AbstractValidator<DeleteDataPegawaiFotoCommand>
    {
        public DeleteDataPegawaiFotoCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }

    }
}
