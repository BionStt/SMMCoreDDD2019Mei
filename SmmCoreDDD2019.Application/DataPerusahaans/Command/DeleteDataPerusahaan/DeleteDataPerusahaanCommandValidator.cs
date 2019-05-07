using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.DeleteDataPerusahaan
{
   public class DeleteDataPerusahaanCommandValidator:AbstractValidator<DeleteDataPerusahaanCommand>
    {
        public DeleteDataPerusahaanCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
