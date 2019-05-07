using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.CreateDataKontrakAsuransi
{
    public class CreateDataKontrakAsuransiCommandValidator:AbstractValidator<CreateDataKontrakAsuransiCommand>
    {
        public CreateDataKontrakAsuransiCommandValidator()
        {

        }
    }
}
