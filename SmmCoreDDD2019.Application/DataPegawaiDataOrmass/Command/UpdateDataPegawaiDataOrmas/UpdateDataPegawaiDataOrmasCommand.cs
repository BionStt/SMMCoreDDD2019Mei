using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.UpdateDataPegawaiDataOrmas
{
    public class UpdateDataPegawaiDataOrmasCommand:IRequest
    {
        public int NoUrut { get; set; }
        public int? IDPegawai { get; set; }
        public string NamaOrmas { get; set; }
        public string AlamatOrmas { get; set; }
        public string KotaOrmas { get; set; }
        public string TelpOrmas { get; set; }
        public string Jabatan { get; set; }
        public string JenisKegiatan { get; set; }
        public DateTime? TglInput { get; set; }
        //   public DataPegawai DataPegawai { get; set; }
    }
}
