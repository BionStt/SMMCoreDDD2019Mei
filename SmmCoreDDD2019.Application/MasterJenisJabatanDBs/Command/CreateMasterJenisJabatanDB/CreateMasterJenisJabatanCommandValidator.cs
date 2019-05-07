using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Command.CreateMasterJenisJabatanDB
{
    public class CreateMasterJenisJabatanCommandValidator:AbstractValidator<CreateMasterJenisJabatanCommand>
    {
        public CreateMasterJenisJabatanCommandValidator()
        {
            RuleFor(x => x.NamaJabatan).NotEmpty();
        

        }
    }
}
