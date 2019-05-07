using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.DeletePermohonanFaktur
{
    public class DeletePermohonanFakturCommandValidator : AbstractValidator<DeletePermohonanFakturCommand>
    {
        public DeletePermohonanFakturCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
