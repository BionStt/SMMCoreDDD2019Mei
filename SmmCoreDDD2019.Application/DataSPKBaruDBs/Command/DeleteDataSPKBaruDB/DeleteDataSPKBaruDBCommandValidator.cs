using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.DeleteDataSPKBaruDB
{
    public class DeleteDataSPKBaruDBCommandValidator:AbstractValidator<DeleteDataSPKBaruDBCommand>
    {
        DeleteDataSPKBaruDBCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
