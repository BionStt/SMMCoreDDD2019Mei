using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.Organization.Domain.ValueObjects;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaan.Commands.CreateDataPerusahaan
{
    public class CreateDataPerusahaanCommand:IRequest<Guid>
    {
        public string NamaPerusahaan { get; set; }
        public string PenanggungJawab { get;  set; }
        public Alamat AlamatPerusahaan { get;  set; }
    }
}
