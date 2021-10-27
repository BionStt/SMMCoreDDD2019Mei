using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.Organization.Domain.ValueObjects;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanCabang.Commands.CreateDataPerusahaanCabang
{
    public class CreateDataPerusahaanCabangCommand : IRequest<Guid>
    {
        public Guid DataPerusahaanId { get; internal set; }
        public string NamaPerusahaanCabang { get; internal set; }
        public Alamat AlamatPerusahaanCabang { get; internal set; }
        public string PenanggungJawab { get; internal set; }
    }
}
