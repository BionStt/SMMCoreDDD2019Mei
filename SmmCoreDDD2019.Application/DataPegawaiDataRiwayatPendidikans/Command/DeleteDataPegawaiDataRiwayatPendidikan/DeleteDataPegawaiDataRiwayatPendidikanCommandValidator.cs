using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.DeleteDataPegawaiDataRiwayatPendidikan
{
  public  class DeleteDataPegawaiDataRiwayatPendidikanCommandValidator:AbstractValidator<DeleteDataPegawaiDataRiwayatPendidikanCommand>
    {
        public DeleteDataPegawaiDataRiwayatPendidikanCommandValidator()
        {

            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
