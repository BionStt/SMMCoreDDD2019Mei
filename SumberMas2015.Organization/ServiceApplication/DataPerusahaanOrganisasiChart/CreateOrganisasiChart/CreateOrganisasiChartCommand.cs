using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanOrganisasiChart.CreateOrganisasiChart
{
    public class CreateOrganisasiChartCommand : IRequest
    {
        public object LokasiJabatan { get;  set; }
        public object NamaStrukturJabatan { get;  set; }
        public object KodeStrukturJabatan { get;  set; }
        public string Parent { get;  set; }
    }
}
