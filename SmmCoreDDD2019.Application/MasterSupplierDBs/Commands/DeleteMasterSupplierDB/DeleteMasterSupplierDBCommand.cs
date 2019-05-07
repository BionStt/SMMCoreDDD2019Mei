using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.DeleteMasterSupplierDB
{
    public class DeleteMasterSupplierDBCommand:IRequest
    {
        public string ID { get; set; }

    }
}
