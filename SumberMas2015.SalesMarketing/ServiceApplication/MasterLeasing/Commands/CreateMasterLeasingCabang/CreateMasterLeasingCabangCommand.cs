using MediatR;
using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Commands.CreateMasterLeasingCabang
{
    public class CreateMasterLeasingCabangCommand:IRequest<Guid>
    {
        public int MasterLeasingId { get; set; }
        public string NamaCabangLeasing { get; set; }
        public string EmailCabang { get; set; }
        public Alamat AlamatLeasingCabang { get; set; }
    }
}
