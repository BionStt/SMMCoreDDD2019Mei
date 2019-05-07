using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.DeleteMasterLeasingCabangDB
{
   public class DeleteMasterLeasingCabangDBCommand:IRequest
    {
        public string Id { get; set; }
    }
}
