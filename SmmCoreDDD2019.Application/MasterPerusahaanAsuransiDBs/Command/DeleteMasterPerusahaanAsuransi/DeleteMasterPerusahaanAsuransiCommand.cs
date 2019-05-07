using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.DeleteMasterPerusahaanAsuransi
{
    public class DeleteMasterPerusahaanAsuransiCommand:IRequest
    {
        public string ID { get; set; }
    }
}
