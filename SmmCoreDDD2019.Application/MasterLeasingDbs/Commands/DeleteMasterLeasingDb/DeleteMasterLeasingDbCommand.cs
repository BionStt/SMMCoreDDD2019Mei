using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.DeleteMasterLeasingDb
{
    public class DeleteMasterLeasingDbCommand:IRequest
    {

        public string ID { get; set; }
    }
}
