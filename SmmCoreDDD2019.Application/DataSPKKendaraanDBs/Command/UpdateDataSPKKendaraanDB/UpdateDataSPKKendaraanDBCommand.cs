using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.UpdateDataSPKKendaraanDB
{
    public class UpdateDataSPKKendaraanDBCommand:IRequest
    {
        public int NoUrut { get; set; }
        public string NamaSTNK { get; set; }
        public string NoKtpSTNK { get; set; }
        public int? NoUrutTypeKendaraan { get; set; }
        public int? NoUrutSPKBaru { get; set; }
        public string TahunPerakitan { get; set; }
        public string Warna { get; set; }
      //  public DataSPKBaruDB DataSPKBaruDB { get; set; }

        //public MasterBarangDb NoUrutTkendNavigation { get; set; }
        //public DataSpkbaruDb NourutSpkbaruNavigation { get; set; }
    }
}
