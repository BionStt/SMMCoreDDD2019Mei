using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.DeleteDataPegawaiDataKeluarga
{
    public class DeleteDataPegawaiDataKeluargaCommand:IRequest
    {
        public string Id { get; set; }
    }
}
