using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanProsesBisnis.CreateProsesBisnis
{
    public class CreateProsesBisnisCommand : IRequest
    {
        public object KodeProsesBisnis { get;  set; }
        public object NamaProsesBisnis { get;  set; }
        public object Aktif { get;  set; }
        public string Parent { get;  set; }
    }
}
