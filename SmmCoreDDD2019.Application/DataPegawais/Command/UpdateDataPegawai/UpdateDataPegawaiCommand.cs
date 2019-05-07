using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawais.Command.UpdateDataPegawai
{
    public class UpdateDataPegawaiCommand:IRequest
    {
        public int IDPegawai { get; set; }

        public DateTime? TglInput { get; set; }

        public DateTime? TglMulaiKerja { get; set; }

        public DateTime? TglBerhentiKerja { get; set; }
        public string Aktif { get; set; }


    }
}
