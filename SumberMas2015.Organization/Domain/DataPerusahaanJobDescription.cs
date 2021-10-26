using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanJobDescription
    {
        public Guid DataPerusahaanJobDescriptionId { get; set; }

        public Guid DataPerusahaanOrganisasiChartId { get; set; }
        public int NoUrutId { get; set; }
        public string LokasiPekerjaanJabatan { get; set; }
        public string TujuanJabatan { get; set; }
        public string TanggungJawabUtama { get; set; }// perlu terpisah dan detail nih
    }
}
