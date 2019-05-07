using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.DeleteDataPegawaiDataOrmas
{
    public class DeleteDataPegawaiDataOrmasCommandValidator:AbstractValidator<DeleteDataPegawaiDataOrmasCommand>
    {
        public DeleteDataPegawaiDataOrmasCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
