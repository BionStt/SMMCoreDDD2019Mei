using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.DeleteDataKontrakSurvei
{
    public class DeleteDataKontrakSurveiCommandValidator:AbstractValidator<DeleteDataKontrakSurveiCommand>
    {
        public DeleteDataKontrakSurveiCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
