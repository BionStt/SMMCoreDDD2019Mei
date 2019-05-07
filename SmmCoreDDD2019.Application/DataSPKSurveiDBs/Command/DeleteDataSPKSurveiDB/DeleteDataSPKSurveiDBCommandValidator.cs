using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.DeleteDataSPKSurveiDB
{
    public class DeleteDataSPKSurveiDBCommandValidator:AbstractValidator<DeleteDataSPKSurveiDBCommand>
    {
        public DeleteDataSPKSurveiDBCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }

    }
}
