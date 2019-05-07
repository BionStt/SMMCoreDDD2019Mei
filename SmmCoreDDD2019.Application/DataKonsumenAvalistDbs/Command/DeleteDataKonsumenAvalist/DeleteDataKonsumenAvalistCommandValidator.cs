using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.DeleteDataKonsumenAvalist
{
    public class DeleteDataKonsumenAvalistCommandValidator:AbstractValidator<DeleteDataKonsumenAvalistCommand>
    {
        public DeleteDataKonsumenAvalistCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
