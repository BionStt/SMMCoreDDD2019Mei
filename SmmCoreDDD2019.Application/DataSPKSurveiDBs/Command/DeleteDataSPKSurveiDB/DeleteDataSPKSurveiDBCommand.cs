using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.DeleteDataSPKSurveiDB
{
    public class DeleteDataSPKSurveiDBCommand:IRequest
    {
        public string Id { get; set; }
    }
}
