using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.DeleteDataPegawaiDataRiwayatPendidikan
{
   public class DeleteDataPegawaiDataRiwayatPendidikanCommand:IRequest
    {
        public int Id { get; set; }
    }
}
