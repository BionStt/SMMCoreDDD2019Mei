using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.DeleteDataPegawaiDataRiwayatPelatihan
{
   public class DeleteDataPegawaiDataRiwayatPelatihanCommand:IRequest
    {
        public string Id { get; set; }
    }
}
