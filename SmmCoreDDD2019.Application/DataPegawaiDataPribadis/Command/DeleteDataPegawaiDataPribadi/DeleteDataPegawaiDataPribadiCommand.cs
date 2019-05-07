using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.DeleteDataPegawaiDataPribadi
{
    public class DeleteDataPegawaiDataPribadiCommand:IRequest
    {
        public string Id { get; set; }
    }
}
