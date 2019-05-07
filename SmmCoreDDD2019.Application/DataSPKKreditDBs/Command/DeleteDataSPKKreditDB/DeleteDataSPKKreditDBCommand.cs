using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.DeleteDataSPKKreditDB
{
    public class DeleteDataSPKKreditDBCommand:IRequest
    {
        public string Id { get; set; }
    }
}
