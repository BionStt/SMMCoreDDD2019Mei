using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.DeleteDataSPKLeasingDB
{
    public class DeleteDataSPKLeasingDBCommand:IRequest
    {
        public string Id { get; set; }
    }
}
