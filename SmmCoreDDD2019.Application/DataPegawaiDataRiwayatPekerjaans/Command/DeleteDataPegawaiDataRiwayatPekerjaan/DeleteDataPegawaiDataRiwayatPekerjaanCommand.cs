using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.DeleteDataPegawaiDataRiwayatPekerjaan
{
    public class DeleteDataPegawaiDataRiwayatPekerjaanCommand : IRequest
    {
        public string Id { get; set; }
    }
}
