using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.CreateDataSPKKendaraanDB
{
    public class CreateDataSPKKendaraanDBCommand:IRequest
    {
        //  public int NoUrut { get; set; }
        [Display(Name = "Nama Pemesan")]
        public int? NoUrutSPKBaru { get; set; }
        [Display(Name = "No KTP Untuk Atas Nama STNK")]
        public string NoKtpSTNK { get; set; }
        [Display(Name = "Nama STNK")]
        public string NamaSTNK { get; set; }
        [Display(Name = "Nama Barang")]
        public int? NoUrutTypeKendaraan { get; set; }
        [Display(Name = "Tahun Perakitan")]
        public string TahunPerakitan { get; set; }
        [Display(Name = "Warna")]
        public string Warna { get; set; }
        
      //  public DataSPKBaruDB DataSPKBaruDB { get; set; }

        //public MasterBarangDb NoUrutTkendNavigation { get; set; }
        //public DataSpkbaruDb NourutSpkbaruNavigation { get; set; }
    }
}
