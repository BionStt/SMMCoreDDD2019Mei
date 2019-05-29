using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataPegawais.Command.CreateDataPegawai
{
  public  class CreateDataPegawaiCommand:IRequest
    {
        public int IDPegawai { get; set; }
     
        public DateTime? TglInput { get; set; }
     
        public DateTime? TglMulaiKerja { get; set; }
       
        public DateTime? TglBerhentiKerja { get; set; }
        public string Aktif { get; set; }
        public string ApplicationUserID { get; set; }

    }
}
