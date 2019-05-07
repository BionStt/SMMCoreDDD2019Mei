using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.DeleteDataPegawaiDataPribadi
{
    public class DeleteDataPegawaiDataPribadiCommandValidator:AbstractValidator<DeleteDataPegawaiDataPribadiCommand>
    {
        public DeleteDataPegawaiDataPribadiCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();

        }

    }
}
