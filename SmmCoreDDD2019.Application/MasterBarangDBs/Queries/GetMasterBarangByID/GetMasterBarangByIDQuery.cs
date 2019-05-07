using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMasterBarangByID
{
    public class GetMasterBarangByIDQuery : IRequest<GetMasterBarangByIDViewModel>
    {
        public string Id { get; set; }
    }
}
