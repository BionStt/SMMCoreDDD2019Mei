using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.DeleteDataPerusahaan
{
   public class DeleteDataPerusahaanCommand:IRequest
    {
        public string Id { get; set; }
    }
}
