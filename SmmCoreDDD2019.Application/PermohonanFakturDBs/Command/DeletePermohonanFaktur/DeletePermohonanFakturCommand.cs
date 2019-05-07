using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.DeletePermohonanFaktur
{
    public class DeletePermohonanFakturCommand : IRequest
    {
        public string Id { get; set; }
    }
}
