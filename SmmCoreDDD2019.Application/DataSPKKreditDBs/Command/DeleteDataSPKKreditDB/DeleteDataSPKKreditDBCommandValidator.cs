using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.DeleteDataSPKKreditDB
{
    public class DeleteDataSPKKreditDBCommandValidator:AbstractValidator<DeleteDataSPKKreditDBCommand>
    {
        public DeleteDataSPKKreditDBCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
