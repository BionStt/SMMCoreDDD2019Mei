using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.DeleteDataSPKKendaraanDB
{
    public class DeleteDataSPKKendaraanDBCommandValidator:AbstractValidator<DeleteDataSPKKendaraanDBCommand>
    {
        public DeleteDataSPKKendaraanDBCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }

    }
}
