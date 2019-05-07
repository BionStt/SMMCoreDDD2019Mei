using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.Nama).NotEmpty();
            RuleFor(x => x.Alamat).NotEmpty();
            RuleFor(x => x.Kota).NotEmpty();
            RuleFor(x => x.Kecamatan).NotEmpty();
            RuleFor(x => x.Kelurahan).NotEmpty();
            RuleFor(x => x.Telp).NotEmpty();
            //RuleFor(x => x.Country).MaximumLength(15);
            //RuleFor(x => x.Fax).MaximumLength(24);
            //RuleFor(x => x.Phone).MaximumLength(24);
            RuleFor(x => x.KodePos).MaximumLength(10).NotEmpty();
           // RuleFor(x => x.Region).MaximumLength(15);
        }
    }
}
