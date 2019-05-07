using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.UpdateDataKontrakKredit
{
    public class UpdateDataKontrakKreditCommandValidator:AbstractValidator<UpdateDataKontrakKreditCommand>
    {
        public UpdateDataKontrakKreditCommandValidator()
        {
            RuleFor(x => x.NoRegisterKontrakKredit).NotEmpty();
        }
    }
}
