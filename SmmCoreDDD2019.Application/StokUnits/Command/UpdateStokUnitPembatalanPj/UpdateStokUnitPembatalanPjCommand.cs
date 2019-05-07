using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.StokUnits.Command.UpdateStokUnitPembatalanPj
{
    public class UpdateStokUnitPembatalanPjCommand:IRequest
    {
        public string NoUrutSO { get; set; }
    }
}
