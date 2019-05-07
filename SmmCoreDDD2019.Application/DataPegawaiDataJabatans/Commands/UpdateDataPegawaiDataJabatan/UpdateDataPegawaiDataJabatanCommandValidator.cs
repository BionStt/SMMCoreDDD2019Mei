using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;

namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.UpdateDataPegawaiDataJabatan
{
    public class UpdateDataPegawaiDataJabatanCommandValidator:AbstractValidator<UpdateDataPegawaiDataJabatanCommand>
    {
        public UpdateDataPegawaiDataJabatanCommandValidator()
        {
            //RuleFor(x => x.Id).MaximumLength(5).NotEmpty();
            //RuleFor(x => x.Address).MaximumLength(60);
            //RuleFor(x => x.City).MaximumLength(15);
            //RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();
            //RuleFor(x => x.ContactName).MaximumLength(30);

        }

    }
}
