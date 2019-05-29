using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Command.CreateDataPegawaiFoto
{
    public class CreateDataPegawaiFotoCommand:IRequest
    {
        //   public int NoUrut { get; set; }
    
        public byte[] Foto { get; set; }
      
      //  public DateTime? Tglinput { get; set; }
        [Display(Name = "Revisi")]
        public string Revisi { get; set; }
        [Display(Name = "Nama Pegawai")]
        public int? IDPegawai { get; set; }
        [Display(Name = "Kode Barcode")]
        public string KodeBarcode { get; set; }
       // public DataPegawai DataPegawai { get; set; }


    }
}
