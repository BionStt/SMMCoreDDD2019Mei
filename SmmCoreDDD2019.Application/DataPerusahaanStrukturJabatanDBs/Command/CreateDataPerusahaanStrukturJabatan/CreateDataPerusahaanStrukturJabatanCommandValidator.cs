using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Command.CreateDataPerusahaanStrukturJabatan
{
    public class CreateDataPerusahaanStrukturJabatanCommandValidator : AbstractValidator<CreateDataPerusahaanStrukturJabatanCommand>
    {
        public CreateDataPerusahaanStrukturJabatanCommandValidator()
        {
            //RuleFor(x => x.Id).Length(5).NotEmpty();
            //RuleFor(x => x.Address).MaximumLength(60);
            //RuleFor(x => x.City).MaximumLength(15);
            //RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();
            //RuleFor(x => x.ContactName).MaximumLength(30);
            //RuleFor(x => x.ContactTitle).MaximumLength(30);
            //RuleFor(x => x.Country).MaximumLength(15);

        }
    }
}
