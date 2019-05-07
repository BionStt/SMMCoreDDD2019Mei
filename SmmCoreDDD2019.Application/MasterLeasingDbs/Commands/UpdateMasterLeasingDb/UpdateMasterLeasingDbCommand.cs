using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.UpdateMasterLeasingDb
{
   public class UpdateMasterLeasingDbCommand:IRequest
    {
        public int IDlease { get; set; }
        public string NamaLease { get; set; }
        //   public ICollection<MasterLeasingCabangDB> MasterLeasingCabangDB { get; private set; }

    }
}
