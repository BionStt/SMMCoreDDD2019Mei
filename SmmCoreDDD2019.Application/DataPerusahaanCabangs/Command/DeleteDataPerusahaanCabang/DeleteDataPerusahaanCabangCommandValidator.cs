using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.DeleteDataPerusahaanCabang
{
   public class DeleteDataPerusahaanCabangCommandValidator:AbstractValidator<DeleteDataPerusahaanCabangCommand>
    {
        public DeleteDataPerusahaanCabangCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
