using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.DeleteDataPegawaiDataRiwayatPelatihan
{
  public  class DeleteDataPegawaiDataRiwayatPelatihanCommandValidator:AbstractValidator<DeleteDataPegawaiDataRiwayatPelatihanCommand>
    {
        public DeleteDataPegawaiDataRiwayatPelatihanCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
