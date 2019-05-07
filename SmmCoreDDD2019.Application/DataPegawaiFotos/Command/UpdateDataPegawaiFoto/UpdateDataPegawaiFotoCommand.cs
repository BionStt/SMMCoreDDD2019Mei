using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.UpdateDataPegawaiFoto
{
   public class UpdateDataPegawaiFotoCommand:IRequest
    {

        public int NoUrut { get; set; }
        public byte[] Foto { get; set; }

        public DateTime? Tglinput { get; set; }
        public string Revisi { get; set; }

        public int? IDPegawai { get; set; }
        public string KodeBarcode { get; set; }
        // public DataPegawai DataPegawai { get; set; }
    }
}
