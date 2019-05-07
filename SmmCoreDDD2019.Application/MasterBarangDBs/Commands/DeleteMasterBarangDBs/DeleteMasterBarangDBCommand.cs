using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Commands.DeleteMasterBarangDBs
{
    public class DeleteMasterBarangDBCommand:IRequest
    {
        public int Id { get; set; }
    }
}
