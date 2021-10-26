using SumberMas2015.Organization.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaan
    {
        public Guid DataPerusahaanId { get; set; }
        public int NoUrutId { get; set; }
        public string NamaPerusahaan { get; set; }
        public Alamat AlamatPerusahaan { get; set; }

        public string PenanggungJawab { get; set; }
    }
}
