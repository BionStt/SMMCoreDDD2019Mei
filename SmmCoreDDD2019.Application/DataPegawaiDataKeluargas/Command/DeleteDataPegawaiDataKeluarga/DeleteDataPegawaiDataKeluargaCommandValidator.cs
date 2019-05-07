using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.DeleteDataPegawaiDataKeluarga
{
    public class DeleteDataPegawaiDataKeluargaCommandValidator:AbstractValidator<DeleteDataPegawaiDataKeluargaCommand>
    {
        public DeleteDataPegawaiDataKeluargaCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
