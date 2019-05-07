using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.DataPegawais.Command.DeleteDataPegawai
{
   public class DeleteDataPegawaiCommandValidator:AbstractValidator<DeleteDataPegawaiCommand>
    {
        public DeleteDataPegawaiCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }

    }
}
