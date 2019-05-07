using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;
using FluentValidation.Validators;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.UpdateCheckPenjualanDetail
{
    public class UpdateCheckPenjualanDetailCommandValidator : AbstractValidator<UpdateCheckPenjualanDetailCommand>
    {
        public UpdateCheckPenjualanDetailCommandValidator()
        {
            //RuleFor(x => x.Nama).NotEmpty();
            //RuleFor(x => x.NamaBPKB).NotEmpty();
            //RuleFor(x => x.Kota).NotEmpty();
            ////RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();
            //RuleFor(x => x.ContactName).MaximumLength(30);
            //RuleFor(x => x.ContactTitle).MaximumLength(30);
            //RuleFor(x => x.Country).MaximumLength(15);
            //RuleFor(x => x.Fax).MaximumLength(24).NotEmpty();
            //RuleFor(x => x.Phone).MaximumLength(24).NotEmpty();
            //RuleFor(x => x.PostalCode).MaximumLength(10);
            //RuleFor(x => x.Region).MaximumLength(15);

            //RuleFor(c => c.PostalCode).Matches(@"^\d{4}$")
            //    .When(c => c.Country == "Australia")
            //    .WithMessage("Australian Postcodes have 4 digits");

            //RuleFor(c => c.Phone)
            //    .Must(HaveQueenslandLandLine)
            //    .When(c => c.Country == "Australia" && c.PostalCode.StartsWith("4"))
            //    .WithMessage("Customers in QLD require at least one QLD landline.");
        }

        //private static bool HaveQueenslandLandLine(UpdateCustomerCommand model, string phoneValue, PropertyValidatorContext ctx)
        //{
        //    return model.Phone.StartsWith("07") || model.Fax.StartsWith("07");
        //}
    }
}
