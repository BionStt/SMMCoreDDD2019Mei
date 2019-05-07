using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQrByNoUrut
{
    public class GetNamaBarangQrByNoUrutQuery : IRequest<GetNamaBarangQrByNoUrutViewModel>
    {
        public string Id { get; set; }
    }
}
