using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.DeleteDataPegawaiFoto
{
   public class DeleteDataPegawaiFotoCommand:IRequest
    {
        public string Id { get; set; }
    }
}
