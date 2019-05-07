using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Command.CreateDataPegawaiDataPribadiInput
{
    public class CreateDataPegawaiDataPribadiInputCommandValidator:AbstractValidator<CreateDataPegawaiDataPribadiInputCommand>
    {
        public CreateDataPegawaiDataPribadiInputCommandValidator()
        {

            RuleFor(x => x.NamaDepan).NotEmpty();
            RuleFor(x => x.Telp).NotEmpty();
            RuleFor(x => x.Handphone).NotEmpty();
            RuleFor(x => x.NoKTP).NotEmpty();
            RuleFor(x => x.AlamatRumah).NotEmpty();

        }
    }
}
