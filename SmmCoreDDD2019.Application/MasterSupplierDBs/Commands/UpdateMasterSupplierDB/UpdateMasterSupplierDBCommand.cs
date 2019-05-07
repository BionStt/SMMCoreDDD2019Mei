using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.UpdateMasterSupplierDB
{
  public  class UpdateMasterSupplierDBCommand:IRequest
    {
        public int IDSupplier { get; set; }
        public string Aktif { get; set; }
        public string Alamat { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }
        public string NamaSupplier { get; set; }
        public string Telp { get; set; }
        public string Faks { get; set; }
        public string Email { get; set; }
    }
}
