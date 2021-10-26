using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanJobSpecification
    {
        public Guid DataPerusahaanJobSpecificationID { get; set; }

        public Guid DataPerusahaanOrganisasiChartId { get; set; }
        public int NoUrutId { get; set; }
        public string MinimalFormalPendidikan { get; set; }
        public string JurusanPendidikan { get; set; }
        public string PengalamanKerjaDalamTahun { get; set; }
    }
}
