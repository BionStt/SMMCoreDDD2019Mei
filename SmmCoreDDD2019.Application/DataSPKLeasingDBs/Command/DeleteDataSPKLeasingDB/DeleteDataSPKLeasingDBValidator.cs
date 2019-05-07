using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.DeleteDataSPKLeasingDB
{
    public class DeleteDataSPKLeasingDBValidator:AbstractValidator<DeleteDataSPKLeasingDBCommand>
    {
        public DeleteDataSPKLeasingDBValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
