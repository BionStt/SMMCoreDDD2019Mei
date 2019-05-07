using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.CreateDataKontrakSurvei
{
    public class CreateDataKontrakSurveiCommandValidator:AbstractValidator<CreateDataKontrakSurveiCommand>
    {
        public CreateDataKontrakSurveiCommandValidator()
        {

        }
    }
}
