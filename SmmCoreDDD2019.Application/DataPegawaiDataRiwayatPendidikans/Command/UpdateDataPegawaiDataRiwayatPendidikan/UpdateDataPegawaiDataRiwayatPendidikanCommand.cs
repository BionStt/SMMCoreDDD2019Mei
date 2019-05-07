using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.UpdateDataPegawaiDataRiwayatPendidikan
{
  public  class UpdateDataPegawaiDataRiwayatPendidikanCommand:IRequest
    {

        public int NoUrut { get; set; }
        public int? IDPegawai { get; set; }
        public string TingkatPend { get; set; }
        public string NamaSekolah { get; set; }
        public string Kota { get; set; }
        public string Jurusan { get; set; }
        public int? TahunLulus { get; set; }
        public string Keterangan { get; set; }
       // public DataPegawai DataPegawai { get; set; }
    }
}
