using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.DeletePenjualanDetail
{
    public class DeletePenjualanDetailCommandValidator : AbstractValidator<DeletePenjualanDetailCommand>
    {
        public string Id { get; set; }
    }
}
