using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.DeleteDataKontrakKredit
{
    public class DeleteDataKontrakKreditCommandValidator:AbstractValidator<DeleteDataKontrakKreditCommand>
    {
        public DeleteDataKontrakKreditCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
