using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.UpdateDataKontrakSurvei
{
    public class UpdateDataKontrakSurveiCommandValidator:AbstractValidator<UpdateDataKontrakSurveiCommand>
    {
        public UpdateDataKontrakSurveiCommandValidator()
        {
            //RuleFor(x => x.Id).MaximumLength(5).NotEmpty();
        }
    }
}
