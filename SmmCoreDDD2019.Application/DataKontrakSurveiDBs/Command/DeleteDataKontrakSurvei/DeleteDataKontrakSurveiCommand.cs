using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.DeleteDataKontrakSurvei
{
    public class DeleteDataKontrakSurveiCommand:IRequest
    {
        public string Id { get; set; }
    }
}
