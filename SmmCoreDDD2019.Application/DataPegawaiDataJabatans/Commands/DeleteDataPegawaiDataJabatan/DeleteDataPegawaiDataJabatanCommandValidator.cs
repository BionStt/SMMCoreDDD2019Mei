using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.DeleteDataPegawaiDataJabatan
{
    public class DeleteDataPegawaiDataJabatanCommandValidator : AbstractValidator<DeleteDataPegawaiDataJabatanCommand>
    {
        public DeleteDataPegawaiDataJabatanCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();

        }
    }
}
