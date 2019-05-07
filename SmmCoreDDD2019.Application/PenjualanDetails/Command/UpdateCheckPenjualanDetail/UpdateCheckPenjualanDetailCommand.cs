using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.UpdateCheckPenjualanDetail
{
    public class UpdateCheckPenjualanDetailCommand:IRequest
    {
        public string NoUrutPenjualanDetail { get; set; }
        public string UserInput { get; set; }
    }
}
