using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.DeleteDataKontrakAsuransi
{
    public class DeleteDataKontrakAsuransiCommandValidator:AbstractValidator<DeleteDataKontrakAsuransiCommand>
    {
        public DeleteDataKontrakAsuransiCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
