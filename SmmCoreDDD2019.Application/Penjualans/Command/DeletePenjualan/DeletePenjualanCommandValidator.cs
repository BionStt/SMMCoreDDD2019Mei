using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.Penjualans.Command.DeletePenjualan
{
    public class DeletePenjualanCommandValidator : AbstractValidator<DeletePenjualanCommand>
    {
        public DeletePenjualanCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
