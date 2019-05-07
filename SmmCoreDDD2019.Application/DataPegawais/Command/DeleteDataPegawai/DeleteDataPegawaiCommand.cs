using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace SmmCoreDDD2019.Application.DataPegawais.Command.DeleteDataPegawai
{
   public  class DeleteDataPegawaiCommand:IRequest
    {
        public string Id { get; set; }
    }
}
