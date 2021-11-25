using SumberMas2015.Organization.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanSalaryStructure
    {
        public Guid DataPerusahaanSalaryStructureid { get; set; }
        public Guid DataPerusahaanOrganisasiChartId { get; set; }
        public string GolonganJabatan { get; set; }

        public decimal UpahPokok { get; set; }

        public TunjanganTetap TunjanganTetap { get; set; }
        public TunjanganTidakTetap TunjanganTidakTetap{ get; set; }
        public BpjsDibayarkanPerusahaan BpjsDibayarkanPerusahaan { get; set; }
        public BpjsDibayarkanTK BpjsDibayarkanTK { get; set; }


    }
}
