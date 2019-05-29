using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.CreateDataPegawaiDataJabatan
{
    public class CreateDataPegawaiDataJabatanCommand:IRequest
    {
        //    public int NoUrut { get; set; }
        [Display(Name = "Nama Pegawai")]
        public int? IDPegawai { get; set; }
        [Display(Name = "Jenis Jabatan")]
        public int? NoUrutJabatan { get; set; }
     
      //  public DateTime? TglMenjabat { get; set; }
     
      //  public DateTime? TglBerhentiMenjabat { get; set; }
  
        public string Keterangan { get; set; }
       // public MasterJenisJabatan MasterJenisJabatan { get; set; }
    }
}
