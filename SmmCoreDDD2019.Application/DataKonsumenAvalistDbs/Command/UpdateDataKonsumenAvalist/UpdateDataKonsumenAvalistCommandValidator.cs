using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.UpdateDataKonsumenAvalist
{
    public class UpdateDataKonsumenAvalistCommandValidator:AbstractValidator<UpdateDataKonsumenAvalistCommand>
    {
        public UpdateDataKonsumenAvalistCommandValidator()
        {
            RuleFor(x => x.NoUrutKonsumen).NotEmpty();
        }
    }
}
