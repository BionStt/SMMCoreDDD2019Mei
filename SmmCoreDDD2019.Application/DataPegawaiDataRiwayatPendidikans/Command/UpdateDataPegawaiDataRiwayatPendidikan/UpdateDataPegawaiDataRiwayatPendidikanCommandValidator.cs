using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using FluentValidation.Validators;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.UpdateDataPegawaiDataRiwayatPendidikan
{
  public  class UpdateDataPegawaiDataRiwayatPendidikanCommandValidator:AbstractValidator<UpdateDataPegawaiDataRiwayatPendidikanCommand>
    {
        public UpdateDataPegawaiDataRiwayatPendidikanCommandValidator()
        {
            //RuleFor(x => x.Nama).NotEmpty();
            //RuleFor(x => x.NamaBPKB).NotEmpty();
            //RuleFor(x => x.Kota).NotEmpty();



        }
    }
}
