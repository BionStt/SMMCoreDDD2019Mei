using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Command.DeleteDataKontrakAngsuran
{
    public class DeleteDataKontrakAngsuranCommandValidator : AbstractValidator<DeleteDataKontrakAngsuranCommand>
    {
        public DeleteDataKontrakAngsuranCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();

        }
    }
}
