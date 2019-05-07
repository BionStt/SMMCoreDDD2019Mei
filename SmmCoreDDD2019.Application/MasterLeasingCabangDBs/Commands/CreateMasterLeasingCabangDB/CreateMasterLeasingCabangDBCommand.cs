using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.CreateMasterLeasingCabangDB
{
   public  class CreateMasterLeasingCabangDBCommand:IRequest
    {
        //  public int NoUrutLeasingCabang { get; set; }
        [Display(Name = "Nama Leasing")]
        public int IDlease { get; set; }

        [Display(Name = "Nama Cabang Leasing")]
        public string Cabang { get; set; }
        public string Alamat { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }

        [Display(Name = "Telepon")]
        public string Telp { get; set; }
        public string Faks { get; set; }
        public string Email { get; set; }
        public string Aktif { get; set; }
        //    public MasterLeasingDb MasterLeasingDb { get; set; }
        // public ICollection<DataSPKLeasingDB> DataSPKLeasingDB { get; private set; }
    }
}
